using System;

namespace BankAccount
{
    class BankAccount
    {
        static void Main()
        {
            Console.WriteLine("Welcome in Unicredit Bulbank");
            Console.WriteLine();
            Console.ReadLine();

            int firstAccountId = 0;
            Console.Write("First account Id: ");
            firstAccountId = int.Parse(Console.ReadLine());
            double firstAccountBalance = 0d;
            Console.Write("First account Balance: ");
            firstAccountBalance = double.Parse(Console.ReadLine());

            Console.WriteLine();

            BankAccount firstAccount = new BankAccount(firstAccountId, firstAccountBalance);

           
            firstAccount.Id = firstAccountId;
            firstAccount.Balance = firstAccountBalance;


            
            int secondAccountId = 0;
            Console.Write("Second account Id: ");
            secondAccountId = int.Parse(Console.ReadLine());
            double secondAccountBalance = 0d;
            Console.Write("Second account Balance: ");
            secondAccountBalance = double.Parse(Console.ReadLine());

            Console.WriteLine();

            BankAccount secondAccount = new BankAccount(secondAccountId, secondAccountBalance);

            secondAccount.Id = secondAccountId;
            secondAccount.Balance = secondAccountBalance;

            

            BankAccount[] accounts = new BankAccount[] { firstAccount, secondAccount};
            foreach (BankAccount accaunt in accounts)
            {
                accaunt.Output();
            }
        }


        
        private int id ;
        private double balance;

        public BankAccount()
        {
        }
        public BankAccount(int id, double balance)
        {
            this.id = id;
            this.balance = balance;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }


        public void Output()
        {
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Balance: {balance:f2}lv.");
            Console.ReadLine();

        }
    }
}
