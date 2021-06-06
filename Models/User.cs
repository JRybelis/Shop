using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShop.Models
{
    public class User
    {
        public decimal AccountBalance { get; set; }

        public void DisplayAccountBalance()
        {
            Console.WriteLine($"Your current account balance is at £{AccountBalance}.");
        }

        public void AccountTopUp(decimal topUpAmount)
        {
            AccountBalance += topUpAmount;
            Console.WriteLine($"The deposit of {topUpAmount} has been accepted.");
            DisplayAccountBalance();
        }
    }
}
