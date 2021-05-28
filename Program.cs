using System;

namespace ConsoleShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();

            //var user = new Customer("Jokūbas", 250);



            shop.ListItems();
            shop.Buy("ItemName", 50);
            shop.LoadItems("ItemName", 50);
        }
    }
}
