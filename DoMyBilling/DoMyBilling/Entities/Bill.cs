using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoMyBilling.Entities
{
    class Bill
    {
        public CompanyInfo Company { get; set; }
        public RecipientInfo Recipient { get; set; }
        public List<ItemInfo> Items { get; set; }
        public Bill(CompanyInfo cinfo, RecipientInfo rinfo, List<ItemInfo> items)
        {
            this.Company = cinfo;
            this.Recipient = rinfo;
            this.Items = items;
        }

        public Bill()
        {

        }
    }
}
