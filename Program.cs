using System;
using System.Collections.Generic;
using ConsoleShop.Models;
using ConsoleShop.Models.Base;
using System.Linq;
using ConsoleShop.BusinessLogic;

namespace ConsoleShop
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopUI shoppe = new ShopUI();
            shoppe.Open();
        }
    }
}
