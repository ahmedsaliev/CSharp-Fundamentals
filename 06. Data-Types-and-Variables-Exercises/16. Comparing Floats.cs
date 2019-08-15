using System;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.000001d;
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            bool compare = Math.Abs(num1 - num2) < eps;

            Console.WriteLine(compare);
        }
    }
}
