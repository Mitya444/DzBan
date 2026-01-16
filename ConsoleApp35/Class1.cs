using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Account
    {
        private string name;
        private double balance;
        private double irlBalance;

        public Account(string name, double balance, double irlBalance)
        {
            this.name = name;
            this.balance = balance;
            this.irlBalance = irlBalance;
        }

        public double Withdrawal(double input_withdrawal)
        {
            if (input_withdrawal >= 0 && input_withdrawal <= balance)
            {
                balance = balance - input_withdrawal;
                irlBalance = irlBalance + input_withdrawal;
                return balance;
            }
            else
            {
                Console.WriteLine("Erorr!");
                return balance;
            }

        }

        public double Deposit(double input_deposit)
        {
            if (input_deposit > 0 && input_deposit <= irlBalance)
            {
                balance = balance + input_deposit;
                irlBalance = irlBalance - input_deposit;
                return balance;
            }
            else
            {
                Console.WriteLine("Error");
                return balance;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Account name: {name} account balance: {balance}");
        }

        public double GetBalance()
        {
            return balance;
        }

    }


}
