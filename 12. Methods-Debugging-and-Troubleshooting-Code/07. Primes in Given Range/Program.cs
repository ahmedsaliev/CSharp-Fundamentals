using System;

namespace _07._Primes_in_Given_Range
{
    class Program
    {
        static bool IsPrime(long number)
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

        static string FindPrimesInRange(int a, int b)
        {
            string result = null;
            for (int i = a; i <= b; i++)
            {
                if (IsPrime(i))
                {
                    if (result == null)
                    {
                        result = i.ToString();
                    }
                    else
                    {
                    result = result + ", " + i.ToString();
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            if (startNum <= endNum)
            {
                Console.WriteLine(FindPrimesInRange(startNum, endNum));
            }
        }
    }
}