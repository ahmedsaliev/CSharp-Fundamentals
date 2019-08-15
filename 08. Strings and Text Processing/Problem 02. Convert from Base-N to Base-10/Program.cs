using System;
using System.Numerics;
using System.Linq;

namespace Problem_02._Convert_from_Base_N_to_Base_10
{
    class Program
    {
        static BigInteger Pow(int number, int pow)
        {
            BigInteger result = 1;
            for (var i = 0; i < pow; i++)
            {
                result *= number;
            }
            return result;
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();
            byte baseNumber = byte.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);
            BigInteger result = 0;
            int pow = 0;
            while (number != 0)
            {
                BigInteger digit = (BigInteger) number % 10;
                number /= 10;
                result += digit * BigInteger.Pow(baseNumber, pow);
                pow++;
            }
            Console.WriteLine(result);
        }
    }
}