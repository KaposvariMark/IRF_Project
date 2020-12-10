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
        public string PhoneNumber { get; set; }
        public string Fax { get; set; }
        public string WebSite { get; set; }
        public string Email { get; set; }
    }
}
