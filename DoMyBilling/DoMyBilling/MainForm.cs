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

namespace DoMyBilling
{
    public partial class MainForm : Form
    {
        Bill bill = createNewBill();

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
                bill = ReadCSV(filePath, bill);
                FillInfoFields(bill);
            }
        }

        private void FillInfoFields(Bill bill)
        {
            lbl_companyName.Text = bill.Company.CompanyName;
            lbl_companyAddress1.Text = bill.Company.AddressPostcodeCity;
            lbl_companyAddress2.Text = bill.Company.AddressStreetNumber;
            lbl_companyTaxID.Text = bill.Company.TaxNumber;

            lbl_recipientName.Text = bill.Recipient.RecipientName;
            lbl_recipientAddress1.Text = bill.Recipient.AddressPostcodeCity;
            lbl_recipientAddress2.Text = bill.Recipient.AddressStreetNumber;
            lbl_recipientTaxID.Text = bill.Recipient.TaxNumber;
        }

        private Bill ReadCSV(string csvpath, Bill bill)
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
    }
}
