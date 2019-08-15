using System;

namespace _04._Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primesArray = new bool[n + 1];

            for (int i = 0; i <= n; i++)
            {
                primesArray[i] = true;
            }

            primesArray[0] = primesArray[1] = false;

            for (int i = 2; i * i <= n; i++)
            {
                if (primesArray[i])
                {
                    for (int j = i * i; j <= n; j = j + i)
                    {
                        primesArray[j] = false;
                    }
                }
            }

            for (int i = 0; i < n + 1; i++)
            {
                if (primesArray[i])
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
