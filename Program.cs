using System;
using System.Collections.Generic;
using ConsoleShop.Models;
using ConsoleShop.Models.Base;
using System.Linq;

namespace ConsoleShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shoppe = new Shop();
            shoppe.Open();

            List<PhoneItem> phones = new List<PhoneItem>();
            phones.Add(new PhoneItem()
            {
                Name = "iPhone",
                PriceDecimal = 1000
            });

            phones.Add(new PhoneItem()
            {
                Name = "Nokia",
                PriceDecimal = 200
            });

            phones.Add(new PhoneItem()
            {
                Name = "Blackberry",
                PriceDecimal = 400
            });

            phones.Add(new PhoneItem()
            {
                Name = "Samsung",
                PriceDecimal = 800
            });

            var phoneLessThan600 = phones.Where(p => p.PriceDecimal < 600).Select(p => p.Name);
            Console.WriteLine(phoneLessThan600);

            //var user = new Customer("Jokūbas", 250);
            var command = "";
            while (command != "Exit")
            {
                Console.WriteLine("Enter your command, please.");
                try
                {
                    command = Console.ReadLine();
                    var number = Decimal.Parse(command);
                    Console.WriteLine($"Number supplied was {number}.");
                    ;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Something went wrong:  {e.Message} Please try again");
                }
            }


            //var shop = new Shop();

            //var tvItem = new TvItem()
            //{
            //    Name = "Phillips Brilliance",
            //    PriceDecimal = 349.99M
            //};

            //var smartWatchItem = new SmartWatchItem()
            //{
            //    Name = "PRO TREK",
            //    PriceDecimal = 219.99M,
            //    Brand = "Casio"
            //};

            //Console.WriteLine(tvItem.ToDescriptionString());
            //Console.WriteLine(smartWatchItem.ToDescriptionString());
            //shop.ListItems();
            //shop.Buy("ItemName", 50);
            //shop.LoadItems("ItemName", 50);

            //Console.ReadLine();
        }
    }
}
