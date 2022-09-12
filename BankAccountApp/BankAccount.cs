using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankAccountApp
{
    public class BankAccount
    {
        private decimal balance = 0; 

        public decimal GetBalance()
        {
            return balance;
        }
        public decimal Deposit(decimal depositAmount)
        {

            if (depositAmount <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("INVALID INPUT - PLEASE ENTER THE AMOUNT OF MONEY YOU WOULD LIKE TO DEPOSIT!");
                Console.ResetColor();
            }
            else
            {
                //ConsoleLogging.Loading();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("SUCCESS!!");
                Console.ResetColor();
                balance += depositAmount;
            }
            return balance;

        }
        public decimal GetWithdraw(decimal withdrawAmount)
        {
          
            if (balance <= 0.0m || withdrawAmount > balance || withdrawAmount <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Insufficient funds!");
                Console.ResetColor();
                return balance;
            }

            else
            {
                balance -= withdrawAmount;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("SUCCESS!!");
                Console.ResetColor();
                return balance;
            }

        }

    }
}
