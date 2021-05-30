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
        protected int secret = 5;

        public string ToDescriptionString()
        {
            return $" Product model: {Name}, price - ${PriceDecimal}.";
;        }
    }
}
