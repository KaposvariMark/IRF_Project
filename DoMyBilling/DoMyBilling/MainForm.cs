using DoMyBilling.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace DoMyBilling
{
    public partial class MainForm : Form
    {
        Bill bill = CreateNewBill();

        Excel.Application xlApp; 
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;

        private static Bill CreateNewBill()
        {
            CompanyInfo cinfo = new CompanyInfo();
            RecipientInfo rinfo = new RecipientInfo();
            List<ItemInfo> items = new List<ItemInfo>();
            Bill newBill = new Bill(cinfo, rinfo, items);
            return newBill;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void AutoFillInfoFields(Bill bill)
        {
            textBox_cName.Text = bill.Company.CompanyName;
            textBox_cAddress1.Text = bill.Company.AddressPostcodeCity;
            textBox_cAddress2.Text = bill.Company.AddressStreetNumber;
            textBox_cTax.Text = bill.Company.TaxNumber;

            textBox_rName.Text = bill.Recipient.RecipientName;
            textBox_rAddress1.Text = bill.Recipient.AddressPostcodeCity;
            textBox_rAddress2.Text = bill.Recipient.AddressStreetNumber;
            textBox_rTax.Text = bill.Recipient.TaxNumber;

            foreach (ItemInfo item in bill.Items)
            {
                string nextItem = item.Item + "; " + item.Quantity + " db; " + item.Sum;
                listBox1.Items.Add(nextItem);
            }
        }

        private Bill ReadCSV(string csvpath, Bill bill)
        {
            using (StreamReader sr = new StreamReader(csvpath, Encoding.UTF8))
            {
                string[] companyInfo = sr.ReadLine().Split(';');
                bill.Company = new CompanyInfo(companyInfo[0], companyInfo[1], companyInfo[2], companyInfo[3]);

                string[] recipientInfo = sr.ReadLine().Split(';');
                bill.Recipient = new RecipientInfo(recipientInfo[0], recipientInfo[1], recipientInfo[2], recipientInfo[3]);

                while (!sr.EndOfStream)
                {
                    string[] itemInfo = sr.ReadLine().Split(';');
                    ItemInfo temp = new ItemInfo(itemInfo[0], int.Parse(itemInfo[1]), int.Parse(itemInfo[2]), int.Parse(itemInfo[3]));
                    bill.Items.Add(temp);
                }
            }
            return bill;
        }

        private void btn_GenerateExcel_Click(object sender, EventArgs e)
        {
            if(comboBoxVAT.SelectedItem == null)
            {
                MessageBox.Show("Choose the amount of VAT!");
                return;
            }
            if (!checkTextBoxes())
            {
                MessageBox.Show("Load a CSV, or fill all empty fields before the generation!");
                return;
            }
            try
            {
                var projectDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Open(projectDir + @"\ExcelBills\BillTemplate.xlsx");
                xlSheet = xlWB.ActiveSheet;
                xlSheet.Copy(Type.Missing, Type.Missing); // Lemásolja a kész számlát, hogy ne az eredeti változzon
                xlSheet = xlApp.Workbooks[2].Sheets[1]; // Megnyitja a másolatot
                xlApp.Workbooks[1].Close(); // Bezárja az eredetit
                FillBill();
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }

        private bool checkTextBoxes()
        {
            if (String.IsNullOrEmpty(textBox_cName.Text)) return false;
            if (String.IsNullOrEmpty(textBox_cAddress1.Text)) return false;
            if (String.IsNullOrEmpty(textBox_cAddress2.Text)) return false;
            if (String.IsNullOrEmpty(textBox_cTax.Text)) return false;
            if (String.IsNullOrEmpty(textBox_rName.Text)) return false;
            if (String.IsNullOrEmpty(textBox_rAddress1.Text)) return false;
            if (String.IsNullOrEmpty(textBox_rAddress2.Text)) return false;
            if (String.IsNullOrEmpty(textBox_rTax.Text)) return false;
            else return true;
        }

        private void FillBill()
        {
            //Date
            xlSheet.Cells[3, 5] = DateTime.Now.ToString("yyyy.MM.dd.");

            //BillID
            xlSheet.Cells[3, 2] = GenerateID(bill.Company.CompanyName, bill.Recipient.RecipientName, bill.Items.Count);

            //CompanyInfo
            xlSheet.Cells[5, 2] = textBox_cName.Text;
            xlSheet.Cells[6, 2] = textBox_cAddress1.Text;
            xlSheet.Cells[7, 2] = textBox_cAddress2.Text;
            xlSheet.Cells[8, 2] = textBox_cTax.Text;

            //RecipientInfo
            xlSheet.Cells[5, 5] = textBox_rName.Text;
            xlSheet.Cells[6, 5] = textBox_rAddress1.Text;
            xlSheet.Cells[7, 5] = textBox_rAddress2.Text;
            xlSheet.Cells[8, 5] = textBox_rTax.Text;

            //ItemInfos
            int itemsStrartingRow = 11;
            int itemRowCount = itemsStrartingRow;
            foreach (ItemInfo item in bill.Items)
            {
                xlSheet.Cells[itemRowCount, 1] = item.Item;
                xlSheet.Cells[itemRowCount, 2] = item.Quantity + " db";
                xlSheet.Cells[itemRowCount, 3] = comboBoxVAT.SelectedItem.ToString();
                xlSheet.Cells[itemRowCount, 4] = item.Price;
                xlSheet.Cells[itemRowCount, 5] = CalcVAT(int.Parse(comboBoxVAT.SelectedItem.ToString()), item.Price);
                xlSheet.Cells[itemRowCount, 6] = item.Sum;
                itemRowCount++;
            }

            //ItemInfoFormatting
            for (int i = itemsStrartingRow; i < itemRowCount; i++)
            {
                Excel.Range ItemRowRange = xlSheet.get_Range(GetCell(i, 1), GetCell(i, 6));
                ItemRowRange.RowHeight = 35;
                ItemRowRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                ItemRowRange.EntireColumn.AutoFit();
                ItemRowRange.Font.Size = 12;
                ItemRowRange.Font.Name = "Tahoma";
                ItemRowRange.Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = 2d;

                if (i % 2 == 0) ItemRowRange.Interior.Color = Color.LightGray; 
                else ItemRowRange.Interior.Color = Color.FromArgb(230,230,230);

                //subSumRowFormatting
                if (i + 1 == itemRowCount)
                {
                    ItemRowRange.Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = 4d;
                    Excel.Range ItemRowRangeSum = xlSheet.get_Range(GetCell(i+1, 1), GetCell(i+1, 6));
                    ItemRowRangeSum.Font.Size = 12;
                    ItemRowRangeSum.EntireColumn.AutoFit();
                    ItemRowRangeSum.Font.Name = "Tahoma";
                }
            }

            //subSumFormatting
            xlSheet.Cells[itemRowCount, 6].Formula = "=SUM(F11:" + GetCell(itemRowCount - 1, 6) + ")";
            xlSheet.Cells[itemRowCount, 5].Formula = "=SUM(E11:" + GetCell(itemRowCount - 1, 5) + ")";
            xlSheet.Cells[itemRowCount, 4] = "Összesen: ";
            xlSheet.Cells[itemRowCount + 2, 4] = "Fizetendő végösszeg:";
            xlSheet.Cells[itemRowCount + 2, 6] = "=SUM("+ GetCell(itemRowCount, 5) +":" + GetCell(itemRowCount, 6) + ")";

            //SumFormatting
            Excel.Range sumCell = xlSheet.get_Range(GetCell(itemRowCount + 2, 4), GetCell(itemRowCount + 2, 6));
            sumCell.Font.Size = 12;
            sumCell.Font.Name = "Tahoma";
            sumCell.Font.Bold = true;
        }

        public string GenerateID(string cName, string rName, int n)
        {
            cName = cName.ToUpper().Substring(0, 2);
            rName = rName.ToUpper().Substring(0, 2);
            n = ((n * n) + 77) * 12;
            return cName + rName + "-" + n.ToString();
        }

        public double CalcVAT(int vat, int price)
        {
            return price * (double)vat / 100;
        }

        public string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }

        private void btn_ImportCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            var filePath = string.Empty;

            ofd.InitialDirectory = "c:\\";
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                lbl_Path.Text = filePath;
                bill = ReadCSV(filePath, bill);
                AutoFillInfoFields(bill);
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lbl_timerTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            lbl_timerDate.Text = DateTime.Now.ToString("yyyy.MM.dd.");
        }

    }
}
