using System;



namespace Scale
{
    class Program
    {
        public class Scale<T> where T : IComparable<T>
        {
            private T left;
            private T right;
            public Scale(T left, T right)
            {
                this.left = left;
                this.right = right;
            }
            public T GetHavier()
            {
                if (left.CompareTo(right) > 0)
                {
                    Console.WriteLine(left);
                }



                else if (left.CompareTo(right) < 0)
                {
                    Console.WriteLine(right);
                }



                else
                {
                    Console.WriteLine("никое");
                }



                return default;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two nums:");
            Scale<int> what = new Scale<int>(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.Write("Bigger num is: ");
            what.GetHavier();



            Console.WriteLine("Enter two words:");
            Scale<string> when = new Scale<string>(Console.ReadLine(), Console.ReadLine());
            Console.Write("Bigger word is: ");
            when.GetHavier();
        }
    }
}