using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_08._Letters_Change_Numbers
{
    class Program
    {
        static void Main()
        {
            //not working
            //string[] input = Console.ReadLine()
            //    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            decimal totalSum = 0;
            foreach (var word in input)
            {
                char startChar = word[0];
                char endChar = word[word.Length - 1];
                string numberAsString = word.Substring(1, word.Length - 2);
                decimal number = decimal.Parse(numberAsString);

                if (startChar >= 'a' && startChar <= 'z')
                {
                    number *= (int)startChar - 96;
                }
                else
                {
 
                    number /= (int)startChar - 64;
                }

                if (endChar >= 'a' && endChar <= 'z')
                {
                    number += (int)endChar - 96;
                }
                else
                {
                    number -= (int)endChar - 64;
                }

                totalSum += number;
            }

            Console.WriteLine("{0:f2}", totalSum);
        }
    }
}