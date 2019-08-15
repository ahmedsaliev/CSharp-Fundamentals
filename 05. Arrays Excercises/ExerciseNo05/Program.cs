using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length of the array: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];

            //Array initialization

            for (int i = 0; i < length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int len = 1;
            int bestLength = 1;
            int bestEnd = 0;

            for (int i = 0; i < length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    len++;

                    if (len > bestLength)
                    {
                        bestLength = len;
                        bestEnd = i + 1;
                    }
                }
                else len = 1;
            }

            //Result printing

            Console.WriteLine("The best rising sequence is:");

            for (int i = 0; i < bestLength; i++)
            {
                Console.Write("{0} ", array[bestEnd - bestLength + i + 1]);
            }
        }
    }
}
