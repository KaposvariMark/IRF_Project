using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoMyBilling.Entities
{
    class RecipientInfo
    {
        public string RecipientName { get; set; }
        public string AddressPostcodeCity { get; set; }
        public string AddressStreetNumber { get; set; }
        public string TaxNumber { get; set; }

        public RecipientInfo(string recipientName, string address1, string address2, string taxNumber)
        {
            this.RecipientName = recipientName;
            this.AddressPostcodeCity = address1;
            this.AddressStreetNumber = address2;
            this.TaxNumber = taxNumber;
        }
        public RecipientInfo()
        {

        }
    }
}
