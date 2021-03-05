using System;

namespace TriangleApp
{
    class Triangle
    {
        public double Area(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public double Area(int a, int b, double angle)
        {
            return a * b * Math.Sin(angle) / 2;
        }
        public double Area(int a, int h)
        {
            return a * h / 2.0;
        }
        public double Area(int a, int b, int c, int R)
        {
            return a * b * c / (double)(4 * R);
        }
        public double Area(int a, int b, int c, double r)
        {
            double p = (a + b + c) / 2;
            return p * r;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Изберете по кой от следните начини искате да пресметнете лицето на триъгълника:");
            Console.WriteLine("1 - чрез въвеждане на трите страни на триъгълника");
            Console.WriteLine("2 - чрез въвеждане на две страни на триъгълника и ъгъл между тях");
            Console.WriteLine("3 - чрез въвеждане на страна на триъгълника и височина към нея");
            Console.WriteLine("4 - чрез въвеждане на трите страни на триъгълника и радиуса на описаната около него окръжност");
            Console.WriteLine("5 - чрез въвеждане на трите страни на триъгълника и радиуса на вписаната в него окръжност");
            Console.Write("Изберете начин (1, 2, 3, 4 или 5): ");

            int type = int.Parse(Console.ReadLine());

                Triangle triangle = new Triangle();

                switch (type)
                {
                    case 1:
                        Console.Write("a: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("b: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.Write("c: ");
                        int c = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Резултат: {triangle.Area(a, b, c)}");
                        break;
                    case 2:
                        Console.Write("a: ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("b: ");
                        b = int.Parse(Console.ReadLine());
                        Console.Write("Ъгъл: ");
                        double angle = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Резултат: {triangle.Area(a, b, angle)}");
                        break;
                    case 3:
                        Console.Write("a: ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("h: ");
                        int h = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Резултат: {triangle.Area(a, h)}");
                        break;
                    case 4:
                        Console.Write("a: ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("b: ");
                        b = int.Parse(Console.ReadLine());
                        Console.Write("c: ");
                        c = int.Parse(Console.ReadLine());
                        Console.Write("R: ");
                        int R = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Резултат: {triangle.Area(a, b, c, R)}");
                        break;
                    case 5:
                        Console.Write("a: ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("b: ");
                        b = int.Parse(Console.ReadLine());
                        Console.Write("c: ");
                        c = int.Parse(Console.ReadLine());
                        Console.Write("r: ");
                        double r = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Резултат: {triangle.Area(a, b, c, r)}");
                        break;
                }
            }            
        }
    }

