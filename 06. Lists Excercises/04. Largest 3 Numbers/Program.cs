using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            numbers.Sort();
            numbers.Reverse();
            var result = numbers.Take(3);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
