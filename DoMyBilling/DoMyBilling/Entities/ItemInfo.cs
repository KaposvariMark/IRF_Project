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

        public ItemInfo(string item, int price, int quantity, int sum)
        {
            this.Item = item;
            this.Price = price;
            this.Quantity = quantity;
            this.Sum = sum;
        }

        public ItemInfo()
        {

        }
    }
}
