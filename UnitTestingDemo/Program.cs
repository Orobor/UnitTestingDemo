using System;
using UnitTestingDemo;
class Program
{
    public static void Main()
    {

        double balance = 100.89;

        eWallet account = new eWallet(balance);

        var acctBalance = account.Withdraw(89); // withdraw 89
        
        Console.WriteLine("The current balance is: " + acctBalance); // Display balance

    }

}

