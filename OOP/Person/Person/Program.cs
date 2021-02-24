using System;

namespace Person
{
    class People
    {
        static void Main()
        {
          
            string firstPeopleName = String.Empty;
            Console.Write("First people name: ");
            firstPeopleName = Console.ReadLine();
            int firstPeopleAge = 0;
            Console.Write("First people age: ");
            firstPeopleAge = int.Parse(Console.ReadLine());

            Console.WriteLine();

            People firstPeople = new People(firstPeopleName, firstPeopleAge);


            firstPeople.Name = firstPeopleName;
            firstPeople.Age = firstPeopleAge;



            string secondPeopleName = String.Empty;
            Console.Write("Second people name: ");
            secondPeopleName = Console.ReadLine();
            int secondPeopleAge = 0;
            Console.Write("Second peole age: ");
            secondPeopleAge = int.Parse(Console.ReadLine());

            Console.WriteLine();

            People secondPeople = new People(secondPeopleName, secondPeopleAge);

            secondPeople.Name = secondPeopleName;
            secondPeople.Age = secondPeopleAge;

            string thirdPeopleName = String.Empty;
            Console.Write("Third people name: ");
            thirdPeopleName = Console.ReadLine();
            int thirdPeopleAge = 0;
            Console.Write("Third peole age: ");
            thirdPeopleAge = int.Parse(Console.ReadLine());

            Console.WriteLine();

            People thirdPeople = new People(thirdPeopleName, thirdPeopleAge);

            thirdPeople.Name = thirdPeopleName;
            thirdPeople.Age = thirdPeopleAge;



            People[] accounts = new People[] { firstPeople, secondPeople, thirdPeople };
            foreach (People accaunt in accounts)
            {
                accaunt.Output();
            }
        }



        private string name;
        private int age;

        public People()
        {
        }
        public People(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public void Output()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.ReadLine();

        }
    }
}
