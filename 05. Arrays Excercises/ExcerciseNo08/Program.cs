using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseNo08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length of the array N = ");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("{0:d2} = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N - 1; i++)
            {
                int min = array[i];
                int index = i;
                for (int j = i + 1; j < N; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        index = j;
                    }
                }
                array[index] = array[i];
                array[i] = min;
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
