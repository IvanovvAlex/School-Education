using System;

namespace Dog_ex
{  
    public class Dog
    {
        static void Main()
        {
            Console.Write(" || ");
            string firstDogName = null;
            Console.Write("Write first dog name: ");
            firstDogName = Console.ReadLine();
            Console.Write(" || ");
            int firstDogAge = 0;
            Console.Write("Write first dog's age: ");
            firstDogAge = int.Parse(Console.ReadLine());
            Console.Write(" || ");
            int firstDogLenght = 0;
            Console.Write("Write first dog's lenght: ");
            firstDogLenght = int.Parse(Console.ReadLine());
            Console.Write(" || ");
            string firstDogSex = String.Empty;
            Console.Write("Write first dog's sex: ");
            firstDogSex = Console.ReadLine().ToLower();
            bool firstDogIsMale = true;
            if (firstDogSex == "female")
            {
                firstDogIsMale = false;
            }
            Console.WriteLine();

            Dog firstDog = new Dog(firstDogName, firstDogAge, firstDogLenght, firstDogIsMale);

            firstDog.name = firstDogName;
            firstDog.age = firstDogAge;
            firstDog.lenght = firstDogLenght;
            firstDog.isMale = firstDogIsMale;

            Console.Write(" || ");
            string secondDogName = null;
            Console.Write("Write second dog name: ");
            secondDogName = Console.ReadLine();
            Console.Write(" || ");
            int secondDogAge = 0;
            Console.Write("Write second dog's age: ");
            secondDogAge = int.Parse(Console.ReadLine());
            Console.Write(" || ");
            int secondDogLenght = 0;
            Console.Write("Write second dog's lenght: ");
            secondDogLenght = int.Parse(Console.ReadLine());
            Console.Write(" || ");
            string secondDogSex = String.Empty;
            Console.Write("Write second dog's sex: ");
            secondDogSex = Console.ReadLine().ToLower();
            bool secondDogIsMale = true;
            if (secondDogSex == "female")
            {
                secondDogIsMale = false;
            }
            Console.WriteLine();
            Dog secondDog = new Dog(secondDogName, secondDogAge, secondDogLenght, secondDogIsMale);
            secondDog.name = secondDogName;
            secondDog.age = secondDogAge;
            secondDog.lenght = secondDogLenght;
            secondDog.isMale = secondDogIsMale;
            


            Console.Write(" || ");
            string thirdDogName = String.Empty;
            Console.Write("Write third dog name: ");
            thirdDogName = Console.ReadLine();
            Console.Write(" || ");
            int thirdDogAge = 0;
            Console.Write("Write third dog's age: ");
            thirdDogAge = int.Parse(Console.ReadLine());
            Console.Write(" || ");
            int thirdDogLenght = 0;
            Console.Write("Write third dog's lenght: ");
            thirdDogLenght = int.Parse(Console.ReadLine());
            Console.Write(" || ");
            string thirdDogSex = String.Empty;
            Console.Write("Write third dog's sex: ");
            thirdDogSex = Console.ReadLine().ToLower();
            bool thirdDogIsMale = true;
            if (thirdDogSex == "female")
            {
                thirdDogIsMale = false;
            }

            Dog thirdDog = new Dog(thirdDogName, thirdDogAge, thirdDogLenght, thirdDogIsMale);

            thirdDog.name = thirdDogName;
            thirdDog.age = thirdDogAge;
            thirdDog.lenght = thirdDogLenght;
            thirdDog.isMale = thirdDogIsMale;

            Dog[] dogs = new Dog[] { firstDog, secondDog, thirdDog};
            foreach (Dog dog in dogs)
            {
                dog.Bark();
            }
        }


        private string name;
        private int age;
        private int lenght;
        private bool isMale;
        public Dog()
        {
        }
        public Dog(string name, int age, int length, bool isMale)
        {
            this.name = name;
            this.age = age;
            this.lenght = length;
            this.isMale = isMale;
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
        public int Lenght
        {
            get { return lenght; }
            set { lenght = value; }
        }
        public bool IsMale
        {
            get { return isMale; }
            set { isMale = value; }
        }

        public void Bark()
        {
            Console.WriteLine($"Name: {name}");        
            Console.WriteLine($"Age: {age}"); 
            Console.WriteLine($"Lenght: {lenght}");
            if (isMale == true)
            {
                Console.WriteLine($"Gender: Male");
            }
            else
            {
                Console.WriteLine($"Gender: Female");
            }         
            Console.WriteLine();
            
        }
    }
}
