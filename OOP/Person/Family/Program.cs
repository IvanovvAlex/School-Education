using System;
using System.Collections.Generic;
using System.Linq;

namespace Family
{
    public class Person
    {
        public Person() { }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }

    public class Family
    {
        public Family()
        {
            this.OrderPersons = new List<Person>();
        }

        public List<Person> OrderPersons { get; set; }

        public void AddMember(Person member)
        {
            OrderPersons.Add(member);
        }

       
        public void GetOldestMember()
        {
            var currentPersona = new Person { Name = "one", Age = -1 };
            foreach (var kvp in OrderPersons)
            {
                if (currentPersona.Age < kvp.Age)
                {
                    currentPersona = kvp;
                }
            }

            Console.WriteLine("{0} {1}", currentPersona.Name, currentPersona.Age);
        }

    } // end class Family

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var currentFamily = new Family();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                var member = new Person(name, age);

                currentFamily.AddMember(member);
            } // end for



            if (currentFamily.OrderPersons.Count > 0)
            {
                currentFamily.GetOldestMember();
            }

        }
    }
}
