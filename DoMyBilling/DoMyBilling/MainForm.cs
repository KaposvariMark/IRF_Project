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
        Bill bill = new Bill();

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

            }
        }

        private Bill ReadCSV(string csvpath, Bill bill)
        {
            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                var companyInfo = sr.ReadLine().Split(';');
                bill.Company.CompanyName = companyInfo[0];
                bill.Company.AddressPostcodeCity = companyInfo[1];
                bill.Company.AddressStreetNumber = companyInfo[2];
                bill.Company.TaxNumber = companyInfo[3];

                var recipientInfo = sr.ReadLine().Split(';');
                bill.Recipient.RecipientName = recipientInfo[0];
                bill.Recipient.AddressPostcodeCity = recipientInfo[1];
                bill.Recipient.AddressStreetNumber = recipientInfo[2];
                bill.Recipient.TaxNumber = recipientInfo[3];

                while (!sr.EndOfStream)
                {
                    var itemInfo = sr.ReadLine().Split(';');
                    bill.Items.Add(new ItemInfo()
                    {
                        Item = itemInfo[0],
                        Price = Convert.ToInt32(itemInfo[1]),
                        Quantity = Convert.ToInt32(itemInfo[2]),
                        Sum = Convert.ToInt32(itemInfo[3]),
                    });
                }
            }
            return bill;
        }
    }
}
