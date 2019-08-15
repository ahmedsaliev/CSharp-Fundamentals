using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];

            Console.Write("K = ");
            int K = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.Write("Element {0:d2} = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            int maxSum = 0;
            int maxIndex = 0;
            int sum = 0;


            for (int i = 0; i < K; i++)
            {
                maxSum = maxSum + array[i];
            }

            for (var i = 1; i <= N - K; i++)
            {
                sum = 0;
                for (int j = 0; j < K; j++)
                {
                    sum = sum + array[i + j];
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxIndex = i;
                }
            }

            Console.WriteLine("Max sum is {0}.", maxSum);

            for (var i = 0; i < K; i++)
            {
                Console.Write("{0} ", array[maxIndex + i]);
            }
        }
    }
}
