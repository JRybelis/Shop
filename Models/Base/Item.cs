using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShop.Models.Base
{
    public abstract class Item
    {
        private string Name { get; set; }
        private decimal PriceDecimal { get; set; }
        private int Quantity { get; set; }

        public string ToDescriptionString() => $" Product model: {Name}, price - ${PriceDecimal}.";
    }
}
