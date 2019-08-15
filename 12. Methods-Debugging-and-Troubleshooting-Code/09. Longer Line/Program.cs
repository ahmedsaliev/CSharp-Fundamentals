using System;

namespace _09._Longer_Line
{
    class Program
    {
        //This method calculates the length of line
        static double LengthOfLine(double a1, double b1, double a2, double b2)
        {
            double length = Math.Sqrt(Math.Pow((Math.Abs(a1 - a2)), 2) + Math.Pow((Math.Abs(b1 - b2)), 2));
            return length;
        }

        //Finding and printing the closest point
        static void PrintClosestPoint(double a1, double b1, double a2, double b2)
        {
            double distance1 = Math.Sqrt(Math.Pow(a1, 2) + Math.Pow(b1, 2));
            double distance2 = Math.Sqrt(Math.Pow(a2, 2) + Math.Pow(b2, 2));
            if (distance1 <= distance2)
            {
                Console.WriteLine($"({a1}, {b1})({a2}, {b2})");
            }
            else
            {
                Console.WriteLine($"({a2}, {b2})({a1}, {b1})");
            }
        }
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            if (LengthOfLine(x1, y1, x2, y2) >= (LengthOfLine(x3, y3, x4, y4)))
            {
                PrintClosestPoint(x1, y1, x2, y2);
            }
            else
            {
                PrintClosestPoint(x3, y3, x4, y4);
            }
        }
    }
}