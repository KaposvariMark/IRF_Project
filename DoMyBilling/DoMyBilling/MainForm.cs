﻿using DoMyBilling.Entities;
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
        Bill bill = createNewBill();

        Excel.Application xlApp; // A Microsoft Excel alkalmazás
        Excel.Workbook xlWB; // A létrehozott munkafüzet
        Excel.Worksheet xlSheet; // Munkalap a munkafüzeten belül

        private static Bill createNewBill()
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

            bill = readCSV(@"C:\Users\Kaposvári Márk\source\repos\IRF_Project\DoMyBilling\DoMyBilling\bin\Debug\PrefectTestCSV.csv", bill);
            autoFillInfoFields(bill);
        }

        private void importCSVToolStripMenuItem_Click(object sender, EventArgs e)
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
                textBoxPath.Text = filePath;
                bill = readCSV(filePath, bill);
                autoFillInfoFields(bill);
            }
        }

        private void autoFillInfoFields(Bill bill)
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

        private Bill readCSV(string csvpath, Bill bill)
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

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lbl_timerTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            lbl_timerDate.Text = DateTime.Now.ToString("yyyy.MM.dd.");
        }

        private void btn_GenerateExcel_Click(object sender, EventArgs e)
        {
            try
            {
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Open(@"C:\Users\Kaposvári Márk\source\repos\IRF_Project\DoMyBilling\DoMyBilling\ExcelBills\BillTemplate.xlsx");
                xlSheet = xlWB.ActiveSheet;
                xlSheet.Copy(Type.Missing, Type.Missing); // Lemásolja a kész számlát, hogy ne az eredeti változzon
                xlSheet = xlApp.Workbooks[2].Sheets[1]; // Megnyitja a másolatot
                xlApp.Workbooks[1].Close(); // Bezárja az eredetit
                fillBill();
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

        private void fillBill()
        {
            //Date
            xlSheet.Cells[3, 5] = DateTime.Now.ToString("yyyy.MM.dd. - HH:mm:ss");

            //BillID
            xlSheet.Cells[3, 3] = "123456789";

            //CompanyInfo
            xlSheet.Cells[5, 3] = bill.Company.CompanyName;
            xlSheet.Cells[6, 3] = bill.Company.AddressPostcodeCity;
            xlSheet.Cells[7, 3] = bill.Company.AddressStreetNumber;
            xlSheet.Cells[8, 3] = bill.Company.TaxNumber;

            //RecipientInfo
            xlSheet.Cells[5, 5] = bill.Recipient.RecipientName;
            xlSheet.Cells[6, 5] = bill.Recipient.AddressPostcodeCity;
            xlSheet.Cells[7, 5] = bill.Recipient.AddressStreetNumber;
            xlSheet.Cells[8, 5] = bill.Recipient.TaxNumber;

            //ItemInfos
            int itemsStrartingRow = 11;
            int counter = itemsStrartingRow;
            foreach (ItemInfo item in bill.Items)
            {
                xlSheet.Cells[counter, 2] = item.Item;
                xlSheet.Cells[counter, 3] = item.Quantity + " db";
                xlSheet.Cells[counter, 4] = item.Price;
                xlSheet.Cells[counter, 5] = item.Sum;
                counter++;
            }

            for (int i = itemsStrartingRow; i < counter; i++)
            {
                Excel.Range ItemRowRange = xlSheet.get_Range(GetCell(i, 2), GetCell(i, 5));
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
                    Excel.Range ItemRowRangeSum = xlSheet.get_Range(GetCell(i+1, 2), GetCell(i+1, 5));
                    ItemRowRangeSum.Font.Size = 12;
                    ItemRowRangeSum.EntireColumn.AutoFit();
                    ItemRowRangeSum.Font.Name = "Tahoma";
                }
            }
            string itemsLastRow = GetCell(counter-1,5);

            xlSheet.Cells[counter, 5].Formula = "=SUM(E11:"+itemsLastRow+")";
            xlSheet.Cells[counter, 4] = "Fizetendő végösszeg: ";
        }

        private string GetCell(int x, int y)
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
    }
}
