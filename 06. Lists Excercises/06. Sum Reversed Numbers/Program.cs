using System;
using System.Collections.Generic;
using System.Linq;


namespace _06._Sum_Reversed_Numbers
{
    class Program
    {
        static string ReverseString(string text)
        {
            string reversed = String.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                reversed = text[i] + reversed;
            }
            return reversed;
        }

        static void Main()
        {
            var numbersAsString = Console.ReadLine()
                .Split(' ')
                .ToList();

            for (int i = 0; i < numbersAsString.Count; i++)
            {
                numbersAsString[i] = ReverseString(numbersAsString[i]);
            }

            var sum = 0;

            for (int i = 0; i < numbersAsString.Count; i++)
            {
                sum += int.Parse(numbersAsString[i]);
            }

            Console.WriteLine(sum);
        }
    }
}
