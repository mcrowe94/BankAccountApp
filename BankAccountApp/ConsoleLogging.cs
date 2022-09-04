using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    public class ConsoleLogging
    {
        public static void MainMenu(decimal balance)
        {
            while (true)
            {
                Console.WriteLine("Welcome to your online bank account!");
                Console.WriteLine();
                Console.WriteLine("What would you like to do today?\n Please pick from the options below:");
                Console.WriteLine("1. CHECK ACCOUNT BALANCE \n2. MAKE A DEPOSIT \n3. MAKE A WITHDRAW \n4. EXIT MENU\n");

                var userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    BankAccount.GetBalance(balance);
                }

                else if (userInput == "2")
                {
                    balance = BankAccount.GetDeposit(balance);
                }

                else if (userInput == "3")
                {
                    balance = BankAccount.GetWithdraw(balance);
                }

                else if (userInput == "4")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Thank you, have a nice day!");
                    Console.ResetColor();
                    Environment.Exit(0);
                }

                Console.WriteLine("Press ENTER to return to MENU...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
