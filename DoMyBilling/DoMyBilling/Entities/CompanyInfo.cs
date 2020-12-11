using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoMyBilling.Entities
{
    class CompanyInfo
    {
        public string CompanyName { get; set; }
        public string AddressPostcodeCity { get; set; }
        public string AddressStreetNumber { get; set; }
        public string TaxNumber { get; set; }

        public CompanyInfo(string companyName, string address1, string address2, string taxNumber)
        {
            this.CompanyName = companyName;
            this.AddressPostcodeCity = address1;
            this.AddressStreetNumber = address2;
            this.TaxNumber = taxNumber;
        }
        public CompanyInfo()
        {

        }
    }
}
