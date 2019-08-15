using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (numbers.Count > array[0])
            {
                numbers.RemoveAt(array[0]);
            }

            for (int i = 0; i < array[1]; i++)
            {
                numbers.RemoveAt(0);
            }

            if (numbers.Contains(array[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}