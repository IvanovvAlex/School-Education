using System;
using System.Collections.Generic;
using System.Text;

namespace _1exBancAcc
{
    public class BankAccount
    {
        private decimal balance;

        private string iban;

        public decimal Balance
        {
            get { return this.balance; }

            private set { this.balance = value; }

        }

        public string Iban
        {
            get { return this.iban; }

            private set { this.iban = value; }
        }

        public BankAccount(decimal balance, string iban)
        {
            this.balance = balance;
            this.iban = iban;
        }

        public void Withdraw(decimal amount)
        {
            Console.WriteLine($"Balance before amount is taken {balance}");
            Console.WriteLine($"Amount to be taken {amount}");
            balance -= amount;
            Console.WriteLine($"After the amount is taken {balance - amount}");
            Console.WriteLine();
        }

        public void Deposit(decimal amount)
        {
            Console.WriteLine($"Balance before amount is added {balance}");
            Console.WriteLine($"Amount to be added {amount}");
            balance += amount;
            Console.WriteLine($"After the amount is added {balance + amount}");
            Console.WriteLine();
        }
    }
}
