using System;


namespace Program
{
    class Circle
    {
        static void Main()
        {

            Console.Write("Enter r: ");
            float r = float.Parse(Console.ReadLine());
           

            Console.WriteLine();

            Circle firstCircle = new Circle(r);

            firstCircle.circleR = r;
            

            Circle[] circles = new Circle[] { firstCircle };
            foreach (Circle circle in circles)
            {
                circle.Print();
            }
        }


        private float circleR;
        


        public Circle()
        {
        }
        public Circle(float r)
        {
            this.circleR = r;
        }
        public float R
        {
            get { return circleR; }
            set { circleR = value; }
        }
       

        public void Print()
        {
            Console.WriteLine($"Area: {(2*Math.PI) * circleR}");
            Console.WriteLine($"Perimeter: {2 * Math.PI * circleR}");

            Console.ReadLine();

        }
    }
}
