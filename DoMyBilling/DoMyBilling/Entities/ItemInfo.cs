using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoMyBilling.Entities
{
    class ItemInfo
    {
        public string Item { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int Sum { get; set; }
    }
}
