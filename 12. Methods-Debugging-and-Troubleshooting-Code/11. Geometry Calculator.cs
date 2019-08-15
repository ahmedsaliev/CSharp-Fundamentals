using System;

namespace _11._Geometry_Calculator
{
    class Program
    {
        static double AreaOfTriangle(double a, double h)
        {
            double area = a * h / 2;
            return area;
        }

        static double AreaOfSquare(double a)
        {
            double area = a * a;
            return area;
        }

        static double AreaOfRectangle(double a, double b)
        {
            double area = a * b;
            return area;
        }

        static double AreaOfCircle(double r)
        {
            double area = Math.PI * r * r;
            return area;
        }

        static void Main()
        {
            string figure = Console.ReadLine();
            switch (figure)
            {
                case "triangle":
                    double sideTriangle = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", AreaOfTriangle(sideTriangle, height));
                    break;
                case "square":
                    double sideSquare = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", AreaOfSquare(sideSquare));
                    break;
                case "rectangle":
                    double side1 = double.Parse(Console.ReadLine());
                    double side2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", AreaOfRectangle(side1, side2));
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", AreaOfCircle(radius));
                    break;
            }
        }
    }
}
