using System;
using ConsoleShop.Models;
using ConsoleShop.Models.Base;

namespace ConsoleShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();

            //var user = new Customer("Jokūbas", 250);

            var tvItem = new TvItem()
            {
                Name = "Phillips Brilliance",
                Price = 349.99
            };

            var smartWatchItem = new SmartWatchItem()
            {
                Name = "PRO TREK",
                Price = 219.99,
                Brand = "Casio"
            };

            Console.WriteLine(tvItem.ToDescriptionString());
            Console.WriteLine(smartWatchItem.ToDescriptionString());
            shop.ListItems();
            shop.Buy("ItemName", 50);
            shop.LoadItems("ItemName", 50);

            Console.ReadLine();
        }
    }
}
