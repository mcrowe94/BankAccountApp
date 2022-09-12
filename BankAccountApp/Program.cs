using System;

namespace BankAccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            ConsoleLogging.MainMenu(account);
        }

        
    }
}
