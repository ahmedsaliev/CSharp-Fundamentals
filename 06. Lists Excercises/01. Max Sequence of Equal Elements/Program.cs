using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main()
        {
            //Reading a list of integers from a single string line
            string valuesString = Console.ReadLine();
            List<string> splittedValues = valuesString.Split(' ').ToList();
            List<int> numbersList = new List<int>();
            for (int i = 0; i < splittedValues.Count; i++)
            {
                numbersList.Add(int.Parse(splittedValues[i]));
            }

            int bestStart = 0;
            int bestLength = 1;
            int start = 0;
            int length = 1;

            for (int i = 0; i < numbersList.Count - 1; i++)
            {
                if (numbersList[i] == numbersList[i + 1])
                {
                    length++;
                }
                else
                {
                    start = i + 1;
                    length = 1;
                }
                if (length > bestLength)
                {
                    bestStart = i;
                    bestLength = length;
                }
            }

            for (int i = 0; i < bestLength; i++)
            {
                Console.Write("{0} ", numbersList[bestStart]);
            }
            Console.WriteLine();
        }
    }
}
