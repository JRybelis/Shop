using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleShop.Models;
using ConsoleShop.Models.Base;

namespace ConsoleShop.BusinessLogic
{
    public class ShopLogic
    {
        public static List<Item> ShopInventory = new List<Item>()
        {
            new Book()
            {
                Name = "The Unofficial Holy Bible for Minecrafters. A children's guide to the Old & New Testament",
                Quantity = 7,
                PriceDecimal = 25.49M
            },
            new Book()
            {
                Name = "The Action Bible. God's redemptive story.",
                Quantity = 1,
                PriceDecimal = 30.00M
            },
            new Sweet()
            {
                Name = "A little tin of sheep poo",
                Quantity = 20,
                PriceDecimal = 9.99M
            },
            new Sweet()
            {
                Name = "Fudge",
                Quantity = 40,
                PriceDecimal = 3.75M
            },
            new Sweet()
            {
                Name = "Brittle",
                Quantity = 80,
                PriceDecimal = 5.95M
            },
            new Cup()
            {
                Name = "Jacob's poison",
                Quantity = 13,
                PriceDecimal = 6.66M
            }
        };
        public static string Sell(object itemSold, int quantity, Customer customer)
        {
            string saleOperation = "";
            switch (itemSold)
            {
                case "book":
                    var book = ShopInventory.FirstOrDefault(i => i is Book);
                    if (book.Quantity < quantity)
                    {
                        saleOperation = $"Insufficient stock levels of {book}. Please offer the customer lower quantity or a substitute product.";
                        break;
                    } else if (book.Quantity * book.PriceDecimal > customer.AccountBalance)
                    {
                        saleOperation =
                            "Insufficient customer account balance. Please offer a lower quantity or a substitute product.";
                        break;
                    }
                    else
                    {
                        book.Quantity -= quantity;
                        customer.AccountBalance -= quantity * book.PriceDecimal;
                        break;
                    } 
                case "cup":
                    var cup = ShopInventory.FirstOrDefault(i => i is Cup);
                    if (cup.Quantity < quantity)
                    {
                        saleOperation =
                            $"Insufficient stock levels of {cup}. Please offer the customer lower quantity or a substitute product.";
                        break;
                    }
                    else if (cup.Quantity * cup.PriceDecimal > customer.AccountBalance)
                    {
                        saleOperation =
                            "Insufficient customer account balance. Please offer a lower quantity or a substitute product.";
                        break;
                    }
                    else
                    {
                        cup.Quantity -= quantity;
                        customer.AccountBalance -= quantity * cup.PriceDecimal;
                        break;
                    }
                case "sweet":
                    var sweet = ShopInventory.FirstOrDefault(i => i is Sweet);
                    if (sweet.Quantity < quantity)
                    {
                        saleOperation = $"Insufficient stock levels of {sweet}. Please offer the customer lower quantity or a substitute product.";
                        break;
                    } else if (sweet.Quantity * sweet.PriceDecimal > customer.AccountBalance)
                    {
                        saleOperation =
                            "Insufficient customer account balance. Please offer a lower quantity or a substitute product.";
                        break;
                    }
                    else
                    {
                        sweet.Quantity -= quantity;
                        customer.AccountBalance -= quantity * sweet.PriceDecimal;
                        break;
                    }
            }

            return saleOperation;

        }

        public static void CustomerBalanceTopUp(Customer customer, decimal amount)
        {
            customer.AccountBalance += amount;
            Console.WriteLine($"The new balance is: £{customer.AccountBalance}");
        }
        public static void AddItem(string itemName, int quantity)
        {
            switch (itemName)
            {
                case "book":
                    var book = ShopInventory.FirstOrDefault(i => i is Book);
                    book.Quantity += quantity;
                    break;
                case "cup":
                    var cup = ShopInventory.FirstOrDefault(i => i is Cup);
                    cup.Quantity += quantity;
                    break;
                case "sweet":
                    var sweet = ShopInventory.First(i => i is Sweet);
                    sweet.Quantity += quantity;
                    break;
            }
        }
        
    }
}
