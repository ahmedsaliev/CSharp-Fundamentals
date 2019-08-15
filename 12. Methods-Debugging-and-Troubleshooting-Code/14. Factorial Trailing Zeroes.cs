using System;
using System.Numerics;

namespace _14._Factorial_Trailing_Zeroes
{
    class Program
    {
        //This method calculates n!

        static BigInteger Factorial(int n)
        {
            BigInteger fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            return fact;
        }

        //This method counts the trailing zeroes of a given number

        static byte CountOfTrailingZeroes(BigInteger n)
        {
            byte count = 0;
            for (int i = 0; i < n.ToString().Length; i++)
            {
                if (n % 10 == 0)
                {
                    count++;
                    n /= 10;
                }
                else
                {
                    break;
                }
            }
            return count;
        }

        // Main code

        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(CountOfTrailingZeroes(Factorial(number)));
        }
    }
}