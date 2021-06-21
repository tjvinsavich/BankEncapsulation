using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {
        }

        private double balance = 0;

        public void Deposit(double value)
        {
            balance = value;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
