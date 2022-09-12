using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankAccountApp
{
    public class ConsoleLogging
    {
        public static void MainMenu(BankAccount account)
        {
            while (true)
            {
                Console.WriteLine("Welcome to your online bank account!");
                Console.WriteLine();
                Console.WriteLine("What would you like to do today?\n Please pick from the options below:");
                Console.WriteLine("1. CHECK ACCOUNT BALANCE \n2. MAKE A DEPOSIT \n3. MAKE A WITHDRAW \n4. EXIT MENU\n");

                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        var balance = account.GetBalance();
                        Console.WriteLine($"Your balance is: {balance,0:c}");
                        break;
                    case "2":
                        Console.WriteLine("How much would you like to deposit?");
                        var deposit = decimal.Parse(Console.ReadLine());
                        account.Deposit(deposit);
                        break;
                    case "3":
                        Console.WriteLine("How much would you like to withdraw?");
                        var withdraw = decimal.Parse(Console.ReadLine());
                        account.GetWithdraw(withdraw);
                        break;
                    case "4":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Thank you, have a nice day!");
                        Console.ResetColor();
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
                
                Console.WriteLine("Press ENTER to return to MENU...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static void Loading()
        {
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
        }
    }
}

#region DEPRICIATED CODE
//if (userInput == "1")
//{
//    BankAccount.GetBalance(balance);
//}

//else if (userInput == "2")
//{
//    balance = BankAccount.GetDeposit(balance);
//}

//else if (userInput == "3")
//{
//    balance = BankAccount.GetWithdraw(balance);
//}

//else if (userInput == "4")
//{
//    Console.Clear();
//    Console.ForegroundColor = ConsoleColor.Yellow;
//    Console.WriteLine("Thank you, have a nice day!");
//    Console.ResetColor();
//    Environment.Exit(0);
//}

//The if else is not bad here but think about using a switch statement to make it a bit cleaner
#endregion
