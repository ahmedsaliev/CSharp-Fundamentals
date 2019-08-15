using System;

namespace _06._Prime_Checker
{
    class Program
    {
        static bool IsPrime(int number)
        {
            bool prime = true;
            if (number > 1)
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                return prime;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }
    }
}
