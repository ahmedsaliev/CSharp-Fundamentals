using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._List_Problems
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string[] numbers = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = input.Length - 1; i <= 0; i--)
            {
                int[] result = numbers[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Console.WriteLine(string.Join(" ", result) + " ");
            }
        }
    }
}
