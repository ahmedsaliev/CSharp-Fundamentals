using System;

namespace RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            //Calculating perimeter and printing it
            double perimeter = 2 * (a + b);
            Console.WriteLine(perimeter);

            //Calculating area and printing it
            double area = a * b;
            Console.WriteLine(area);

            //Calculating diagonal and printing it
            double diagonal = Math.Sqrt((a * a + b * b));
            Console.WriteLine(diagonal);
        }
    }
}
