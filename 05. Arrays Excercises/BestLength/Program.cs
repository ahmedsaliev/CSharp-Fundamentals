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
            int bestStart = 0;
            int bestLength = 1;

            for (int i = 0; i < length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    len++;
                    if (len > bestLength)
                    {
                        bestLength = len;
                        bestStart = i;
                    }
                }
                else
                {               
                    len = 1;
                }
            }

            //Result printing

            Console.WriteLine("The best sequence is:");

            for (int i = 0; i < bestLength; i++)
            {
                Console.Write("{0} ", array[bestStart]);
            }
        }
    }
}
