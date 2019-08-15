using System;

namespace _08._Center_Point
{
    class Program
    {
        static void ClosestPoint(double a1, double b1, double a2, double b2)
        {
            double distance1 = Math.Sqrt(Math.Pow(a1, 2) + Math.Pow(b1, 2));
            double distance2 = Math.Sqrt(Math.Pow(a2, 2) + Math.Pow(b2, 2));
            if (distance1 <= distance2)
            {
                Console.WriteLine($"({a1}, {b1})");
            }
            else
            {
                Console.WriteLine($"({a2}, {b2})");
            }
        }

        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            ClosestPoint(x1, y1, x2, y2);
        }
    }
}
