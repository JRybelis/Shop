using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleShop.Models;
using ConsoleShop.Models.Base;

namespace ConsoleShop.BusinessLogic
{
    internal class ShopUI
    {
        private bool _isOpen = false;
        private List<Item> _shopInventory;
        private Customer _customer;
        private readonly string _name;

        public ShopUI(string name)
        {
            _name = name;
            if (_isOpen)
            {
                throw new Exception("The shop manager app is already running.");
            }

            _isOpen = true;
            _shopInventory = ShopLogic.ShopInventory;
            _customer = new Customer();
        }

        public ShopUI() : this("Bay Flea Market")
        {

        }

        public void Open()
        {
            Console.WriteLine("Welcome to Lancaster Sweet Shoppe!");
            string[] menuSelections;
            do
            {
                menuSelections = MainMenu();
                switch (menuSelections[0])
                {
                    case "l":
                        Console.Clear();
                        ListInventory();
                        break;
                    case "s":
                        Console.Clear();
                        Sale(menuSelections[1], int.Parse(menuSelections[2]));
                        break;
                    case "b":
                        Console.Clear();
                        _customer.DisplayAccountBalance();
                        break;
                    case "t":
                        Console.Clear();
                        ShopLogic.CustomerBalanceTopUp(_customer, decimal.Parse(menuSelections[1]));
                        break;
                    case "a":
                        Console.Clear();
                        AddItems(menuSelections[1], int.Parse(menuSelections[2]));
                        break;
                }
            } while (menuSelections[0] != "c");
        }

        private string[] MainMenu()
        {
            Console.WriteLine("  Please select one of the lettered options below.  ");
            Console.WriteLine("====================================================");
            Console.WriteLine("||  . L: list items    .  .  .  .  .  .  .  .  .  ||");
            Console.WriteLine("||-( )----------------( )( )( )( )( )( )( )( )( )-||");
            Console.WriteLine("||  \"                  \"  \"  \"  \"  \"  \"  \"  \"  \"  ||");
            Console.WriteLine("||  .  .  S: sell items   .  .  .  .  .  .  .  .  ||");
            Console.WriteLine("||-( )( )----------------( )( )( )( )( )( )( )( )-||");
            Console.WriteLine("||  \"  \"                  \"  \"  \"  \"  \"  \"  \"  \"  ||");
            Console.WriteLine("||  .  .  . B: show balance  .  .  .  .  .  .  .  ||");
            Console.WriteLine("||-( )( )( )----------------( )( )( )( )( )( )( )-||");
            Console.WriteLine("||  \"  \"  \"                  \"  \"  \"  \"  \"  \"  \"  ||");
            Console.WriteLine("||  .  .  .  . T: topup balance .  .  .  .  .  .  ||");
            Console.WriteLine("||-( )( )( )( )----------------( )( )( )( )( )( )-||");
            Console.WriteLine("||  \"  \"  \"  \"                  \"  \"  \"  \"  \"  \"  ||");
            Console.WriteLine("||  .  .  .  .  . A: add items     .  .  .  .  .  ||");
            Console.WriteLine("||-( )( )( )( )( )----------------( )( )( )( )( )-||");
            Console.WriteLine("||  \"  \"  \"  \"  \"                  \"  \"  \"  \"  \"  ||");
            Console.WriteLine("||  .  .  .  .  .  . C: close up      .  .  .  .  ||");
            Console.WriteLine("||-( )( )( )( )( )( )----------------( )( )( )( )-||");
            Console.WriteLine("||  \"  \"  \"  \"  \"  \"                  \"  \"  \"  \"  ||");
            Console.WriteLine("||  .  .  .  .  .  .  .                  .  .  .  ||");
            Console.WriteLine("||-( )( )( )( )( )( )( )----------------( )( )( )-||");
            Console.WriteLine("||  \"  \"  \"  \"  \"  \"  \"                  \"  \"  \"  ||");
            Console.WriteLine("||  .  .  .  .  .  .  .  .                  .  .  ||");
            Console.WriteLine("||-( )( )( )( )( )( )( )( )----------------( )( )-||");
            Console.WriteLine("||  \"  \"  \"  \"  \"  \"  \"  \"                  \"  \"  ||");
            Console.WriteLine("||  .  .  .  .  .  .  .  .  .                  .  ||");
            Console.WriteLine("||-( )( )( )( )( )( )( )( )( )----------------( )-||");
            Console.WriteLine("||  \"  \"  \"  \"  \"  \"  \"  \"  \"                  \"  ||");
            Console.WriteLine("||  .  .  .  .  .  .  .  .  .  .                  ||");
            Console.WriteLine("||-( )( )( )( )( )( )( )( )( )( )-----------------||");
            Console.WriteLine("||  \"  \"  \"  \"  \"  \"  \"  \"  \"  \"                  ||");
            Console.WriteLine("====================================================");

            string[] menuSelection = Console.ReadLine().ToLower().Split(" ");
            return menuSelection;

        }
        public void ListInventory()
        {
            Console.WriteLine("                  Shop inventory:                   ");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            foreach (var item in _shopInventory)
            {
                Console.WriteLine($"{item.Name}, £{item.PriceDecimal}, in stock: {item.Quantity}.");
            }
            Console.WriteLine();
            Console.WriteLine("====================================================");
        }

        public void Sale(string itemName, int quantity)
        {
            string saleOperation = ShopLogic.Sell(itemName, quantity, _customer);

            if (saleOperation == "")
            {
                Console.WriteLine($"You have sold {quantity} of {itemName} to {_customer}.");
            }
            else
            {
                Console.WriteLine(saleOperation);
            }
        }

        public void AddItems(string itemName, int quantity)
        {
            ShopLogic.AddItem(itemName, quantity);
            Console.WriteLine($"You have added {quantity} {itemName}s to the shop inventory.");
        }
    }
}
