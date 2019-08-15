using System;
using System.Linq;

namespace _07._Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                            .Split(' ')
                            .Select(s => int.Parse(s))
                            .ToArray();

            int length = 1;
            int bestEnd = 0;
            int bestLength = 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    length++;
                    if (length > bestLength)
                    {
                        bestLength = length;
                        bestEnd = i + 1;
                    }
                }
                else
                {
                    length = 1;
            }
            }

            //Result printing

            for (int i = bestEnd - bestLength + 1; i < bestEnd + 1; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}