using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Fold_and_Sum
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int length = numbers.Length;
            int k = length / 4;

            int[] leftArray = numbers.Take(k).Reverse().ToArray();
            int[] rigthArray = numbers.Reverse().Take(k).ToArray();
            int[] middleArray = numbers.Skip(k).Take(2 * k).ToArray();
            int[] concatArray = leftArray.Concat(rigthArray).ToArray();

            for (int i = 0; i < 2 * k; i++)
            {
                Console.Write("{0} ", middleArray[i] + concatArray[i]);
            }
        }
    }
}
