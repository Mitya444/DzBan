
Account heikkisAccount = new Account("Heikki's account", 100.00, 95.00);
Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 1000000.00, 2511.00);


heikkisAccount.Withdrawal(20);
Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.GetBalance());
heikkisSwissAccount.Deposit(200);
Console.WriteLine("The balance of Heikki's other account is now: " + heikkisSwissAccount.GetBalance());

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

