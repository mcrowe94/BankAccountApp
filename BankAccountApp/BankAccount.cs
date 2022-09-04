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
        public static void GetBalance(decimal balance)
        {
            Console.WriteLine($"Your balance is: {balance,0:c}");
        }
        public static decimal GetDeposit(decimal balance)
        {
            Console.WriteLine("How much would you like to desposit?");

            var userInput = decimal.Parse(Console.ReadLine());

            for (int i = 0; i < 20; i++)
            {
                Console.Write("| -");
                Thread.Sleep(50);
                Console.Write("\b\b\b");
                Console.Write("/ \\");
                Thread.Sleep(50);
                Console.Write("\b\b\b");
                Console.Write("- |");
                Thread.Sleep(50);
                Console.Write("\b\b\b");
                Console.Write("\\ /");
                Thread.Sleep(50);
                Console.Write("\b\b\b");
            }

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
