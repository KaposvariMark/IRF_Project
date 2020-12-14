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

            //bill = ReadCSV(@"C:\Users\Kaposvári Márk\source\repos\IRF_Project\DoMyBilling\DoMyBilling\bin\Debug\PrefectTestCSV.csv", bill);
            //AutoFillInfoFields(bill);
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
            try
            {
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Open(@"C:\Users\Kaposvári Márk\source\repos\IRF_Project\DoMyBilling\DoMyBilling\ExcelBills\BillTemplate.xlsx");
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

        private void FillBill()
        {
            //Date
            xlSheet.Cells[3, 5] = DateTime.Now.ToString("yyyy.MM.dd. - HH:mm:ss");

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
            int counter = itemsStrartingRow;
            foreach (ItemInfo item in bill.Items)
            {
                xlSheet.Cells[counter, 1] = item.Item;
                xlSheet.Cells[counter, 2] = item.Quantity + " db";
                xlSheet.Cells[counter, 3] = comboBoxVAT.SelectedItem.ToString();
                xlSheet.Cells[counter, 4] = item.Price;
                xlSheet.Cells[counter, 5] = CalcVAT(int.Parse(comboBoxVAT.SelectedItem.ToString()), item.Price);
                xlSheet.Cells[counter, 6] = item.Sum;
                counter++;
            }

            for (int i = itemsStrartingRow; i < counter; i++)
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

                // Végösszeg sor formázása
                if (i + 1 == counter)
                {
                    ItemRowRange.Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = 4d;
                    Excel.Range ItemRowRangeSum = xlSheet.get_Range(GetCell(i+1, 1), GetCell(i+1, 6));
                    ItemRowRangeSum.Font.Size = 12;
                    ItemRowRangeSum.EntireColumn.AutoFit();
                    ItemRowRangeSum.Font.Name = "Tahoma";
                }
            }
            string sumCell = GetCell(counter-1,6);
            string vatCell = GetCell(counter-1,5);

            xlSheet.Cells[counter, 6].Formula = "=SUM(F11:" + sumCell + ")";
            xlSheet.Cells[counter, 5].Formula = "=SUM(E11:" + vatCell + ")";
            xlSheet.Cells[counter, 4] = "Összesen: ";
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
