using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main()
        {
            List<double> numbers = new List<double>();

            numbers = Console.ReadLine()
                .Split()
                .Select(x => double.Parse(x))
                .ToList();

            SortedDictionary<double, int> numbersCount = new SortedDictionary<double, int>();

            // Countin numbers

            foreach (var number in numbers)
            {
                if (numbersCount.ContainsKey(number))
                {
                    numbersCount[number]++;
                }
                else
                {
                    numbersCount.Add(number, 1);
                }
            }

            // Printing numbers

            foreach (var pair in numbersCount)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
