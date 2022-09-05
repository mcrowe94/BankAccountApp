using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankAccountApp
{
    internal class BankAccount
    {
        //Think about removing Console.WriteLine() from the methods. Having one line in the Main() is cool but not always appropriate.
        //Try to not pass dialog in these methods below. 

        //Both of your methods (Deposit and Withdraw) are taking a balance as an argument through the params,
        //Ideally, balance would belong to the BankAccount class.
        //The method should probably take an amount to deposit/withdraw through the params instead.

        public static void GetBalance(decimal balance)
        {
            Console.WriteLine($"Your balance is: {balance,0:c}");
        }
        public static decimal GetDeposit(decimal balance)
        {
            //I was able to deposit -$100. Maybe think of a way to handle not depositing negative numbers

            Console.WriteLine("How much would you like to desposit?");

            var userInput = decimal.Parse(Console.ReadLine());

            //Think about making this a method in the ConsoleLogging class you could call it Loading() or something like that. Pretty neat though!
            ConsoleLogging.Loading();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SUCCESS!!");
            Console.ResetColor();
            balance += userInput;
            return balance;
        }
        public static decimal GetWithdraw(decimal balance)
        {
            Console.WriteLine("How much would you like to withdraw?");
            var userInput = decimal.Parse(Console.ReadLine());

            if (balance <= 0.0m || userInput > balance)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Insufficient funds!");
                Console.ResetColor();
                return balance;
            }

            else
            {
                balance -= userInput;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("SUCCESS!!");
                Console.ResetColor();
                return balance;
            }

        }

    }
}
