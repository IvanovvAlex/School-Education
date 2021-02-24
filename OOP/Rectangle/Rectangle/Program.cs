using System;


namespace Program
{
    class Triangle
    {
        static void Main()
        {

            Console.Write("Enter height: ");
            float height = float.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            float width = float.Parse(Console.ReadLine());

            Console.WriteLine();

            Triangle firstTriangle = new Triangle(height, width);

            firstTriangle.triangleHeight = height;
            firstTriangle.triangleWidth = width;

            Triangle[] triangles = new Triangle[] { firstTriangle };
            foreach (Triangle triangle in triangles)
            {
                triangle.Print();
            }
        }


        private float triangleHeight;
        private float triangleWidth;


        public Triangle()
        {
        }
        public Triangle(float height, float width)
        {
            this.triangleHeight = height;
            this.triangleWidth = width;
        }
        public float Height
        {
            get { return triangleHeight; }
            set { triangleHeight = value; }
        }
        public float Width
        {
            get { return triangleWidth; }
            set { triangleWidth = value; }
        }

        public void Print()
        {
            Console.WriteLine($"Area: {triangleHeight * triangleWidth}");
            Console.WriteLine($"Perimeter: {2 * (triangleHeight + triangleWidth)}");

            Console.ReadLine();

        }
    }
}

