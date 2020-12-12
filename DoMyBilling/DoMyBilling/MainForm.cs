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
        }

        private Bill readCSV(string csvpath, Bill bill)
        {
            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
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
                xlWB = xlApp.Workbooks.Open(@"C:\Users\Kaposvári Márk\source\repos\IRF_Project\DoMyBilling\DoMyBilling\ExcelBills\BillType1.xlsx");
                xlSheet = xlWB.ActiveSheet;
                //createTable();
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
    }
}
