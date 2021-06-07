using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShop.Models.Base
{
    public abstract class Item
    {
        public string Name { get; set; }
        public decimal PriceDecimal { get; set; }
        public int Quantity { get; set; }

        public string ToDescriptionString() => $" Product model: {Name}, price - ${PriceDecimal}.";
    }
}
