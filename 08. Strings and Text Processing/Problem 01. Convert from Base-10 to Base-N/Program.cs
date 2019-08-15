using System;
using System.Numerics;

namespace Problem_01._Convert_from_Base_10_to_Base_N
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split();
            byte baseNumber = byte.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);
            string result = string.Empty;
            while (number != 0)
            {
                result = number % baseNumber + result;
                number /= baseNumber;
            }
            Console.WriteLine(result);
        }
    }
}C:\Users\Есма\source\repos\08. Strings and Text Processing\Problem 02. Convert from Base-N to Base-10\Program.cs