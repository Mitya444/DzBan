using ConsoleApp35;
using System;

namespace ConsoleApp35
{
    class Program
    {
        static void Main()
        {
            Account heikkisAccount = new Account("Heikki's account", 100.00, 95.00);
            Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 1000000.00, 2511.00);

            heikkisAccount.Withdrawal(20);
            Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.GetBalance());

            heikkisSwissAccount.Deposit(200);
            Console.WriteLine("The balance of Heikki's other account is now: " + heikkisSwissAccount.GetBalance());
        }
    }
}
