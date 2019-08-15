using System;
using System.Numerics;

namespace Problem_02._Convert_from_Base_N_to_Base_10___2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Trim().Split();
            int baseN = int.Parse(line[0]);
            char[] number = line[1].ToCharArray();

            BigInteger result = new BigInteger(0);

            for (int i = number.Length - 1, n = 0; i >= 0; i--, n++)
            {
                BigInteger num = new BigInteger(char.GetNumericValue(number[n]));
                BigInteger forSum = BigInteger.Multiply(num, BigInteger.Pow(new BigInteger(baseN), i));
                result += forSum;
            }
            Console.WriteLine(result.ToString());

            Math.Pow(2, 4);
            BigInteger.Pow(1, 4);
            char symbol = '8';
            int number = char.GetNumericValue(symbol);
        }

    }
}