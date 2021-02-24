using System;


namespace Program
{
    class Workers
    {
        static void Main()
        {
            Console.WriteLine("Algona LTD.");


            string firstWorkerName = null;
            Console.Write("Write first worker name: ");
            firstWorkerName = Console.ReadLine();
            string firstWorkerTitle = null;
            Console.Write("Write first worker's title: ");
            firstWorkerTitle = Console.ReadLine();
            double firstWorkerSalary = 0;
            Console.Write("Write first worker's salary: ");
            firstWorkerSalary = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Workers firstWorker = new Workers(firstWorkerName, firstWorkerTitle, firstWorkerSalary);

            firstWorker.name = firstWorkerName;
            firstWorker.title = firstWorkerTitle;
            firstWorker.salary = firstWorkerSalary;


            string secondWorkerName = null;
            Console.Write("Write second worker name: ");
            secondWorkerName = Console.ReadLine();
            string secondWorkerTitle = null;
            Console.Write("Write second worker's title: ");
            secondWorkerTitle = Console.ReadLine();
            double secondWorkerSalary = 0;
            Console.Write("Write second worker's salary: ");
            secondWorkerSalary = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Workers secondWorker = new Workers(secondWorkerName, secondWorkerTitle, secondWorkerSalary);

            secondWorker.name = secondWorkerName;
            secondWorker.title = secondWorkerTitle;
            secondWorker.salary = secondWorkerSalary;

            string thirdWorkerName = null;
            Console.Write("Write third worker name: ");
            thirdWorkerName = Console.ReadLine();
            string thirdWorkerTitle = null;
            Console.Write("Write third worker's title: ");
            thirdWorkerTitle = Console.ReadLine();
            double thirdWorkerSalary = 0;
            Console.Write("Write third worker's salary: ");
            thirdWorkerSalary = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Workers thirdWorker = new Workers(thirdWorkerName, thirdWorkerTitle, thirdWorkerSalary);

            thirdWorker.name = thirdWorkerName;
            thirdWorker.title = thirdWorkerTitle;
            thirdWorker.salary = thirdWorkerSalary;

            string fourWorkerName = null;
            Console.Write("Write four worker name: ");
            fourWorkerName = Console.ReadLine();
            string fourWorkerTitle = null;
            Console.Write("Write four worker's title: ");
            fourWorkerTitle = Console.ReadLine();
            double fourWorkerSalary = 0;
            Console.Write("Write four worker's salary: ");
            fourWorkerSalary = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Workers fourWorker = new Workers(fourWorkerName, fourWorkerTitle, fourWorkerSalary);

            fourWorker.name = fourWorkerName;
            fourWorker.title = fourWorkerTitle;
            fourWorker.salary = fourWorkerSalary;

            string fiveWorkerName = null;
            Console.Write("Write five worker name: ");
            fiveWorkerName = Console.ReadLine();
            string fiveWorkerTitle = null;
            Console.Write("Write five worker's title: ");
            fiveWorkerTitle = Console.ReadLine();
            double fiveWorkerSalary = 0;
            Console.Write("Write five worker's salary: ");
            fiveWorkerSalary = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Workers fiveWorker = new Workers(fiveWorkerName, fiveWorkerTitle, fiveWorkerSalary);

            fiveWorker.name = fiveWorkerName;
            fiveWorker.title = fiveWorkerTitle;
            fiveWorker.salary = fiveWorkerSalary;


            Workers[] workers = new Workers[] { firstWorker, secondWorker, thirdWorker, fourWorker, fiveWorker };
            foreach (Workers dog in workers)
            {
                dog.Bark();
            }
        }


        private string name;
        private string title;
        private double salary;

        public Workers()
        {
        }
        public Workers(string name, string title, double salary)
        {
            this.name = name;
            this.title = title;
            this.salary = salary;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        public void Bark()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Salary: {salary:f2}lv.");
            Console.ReadLine();

        }
    }
}