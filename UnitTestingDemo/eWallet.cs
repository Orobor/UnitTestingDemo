using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingDemo
{
    public class eWallet
    {
        private double balance;
        public eWallet(double accountBalance)
        {
            balance = accountBalance;
        }
        public double Withdraw(double amount)
        {
            
            if (amount > balance)
            {
                throw new ArgumentOutOfRangeException("Insufficient Fund!");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid Amount Specified!");
            }

            balance -= amount;
            return balance;

        }

    }
}
