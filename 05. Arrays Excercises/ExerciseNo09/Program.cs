using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseNo09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int maxSum = array[0];
            int maxLength = 1;
            int maxStarter = 0;

            for (int i = 0; i < n; i++)
            {
                int suma = array[i];
                int length = 1;

                for (int j = i + 1; j < n; j++)
                {
                    if (suma < suma + array[j])
                    {
                        suma = suma + array[j];
                        length++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (suma > maxSum)
                {
                    maxSum = suma;
                    maxLength = length;
                    maxStarter = i;
                }
            }
            Console.WriteLine("Max sum is: {0}", maxSum);

            for (int i = maxStarter; i < maxStarter + maxLength; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
