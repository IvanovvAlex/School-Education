using System;

namespace Methods__Bank_Account
{
    class BankAccount
    {
        static void Main()
        {
            Console.WriteLine("Welcome in Unicredit Bulbank");
            Console.WriteLine();
            Console.ReadLine();

            int firstAccountId = 0;
            Console.Write("Account Id: ");
            firstAccountId = int.Parse(Console.ReadLine());
            decimal firstAccountBalance = 0m;
            Console.Write("Account Balance: ");
            firstAccountBalance = decimal.Parse(Console.ReadLine());

            Console.WriteLine();

            BankAccount firstAccount = new BankAccount(firstAccountId, firstAccountBalance);


            firstAccount.Id = firstAccountId;
            firstAccount.Balance = firstAccountBalance;




            string command = Console.ReadLine();
            while (command != "end")
            {
                string secondCommand = command;
                switch (secondCommand)
                {
                    case "Deposit":
                        decimal money = decimal.Parse(Console.ReadLine());
                        firstAccount.balance += money;
                        break;
                    case "Withdraw":
                        decimal money2 = decimal.Parse(Console.ReadLine());
                        firstAccount.balance -= money2;
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
                command = Console.ReadLine();

            }
            Console.WriteLine($"Account {firstAccount.id}, balance {firstAccount.balance:f2}lv.");
        }



        private int id;
        private decimal balance;

        public BankAccount()
        {
        }
        public BankAccount(int id, decimal balance)
        {
            this.id = id;
            this.balance = balance;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }


        
    }
}
