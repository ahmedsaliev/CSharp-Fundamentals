using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_07._Multiply_Big_Number
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine().TrimStart('0');
            int multiplier = int.Parse(Console.ReadLine());

            if (str == string.Empty)
            {
                str = "0";
            }

            if (str == "0" || multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int numberInMind = 0;
            List<int> result = new List<int>();
            for (var i = str.Length - 1; i >= 0; i--)
            {
                int num = (int)Char.GetNumericValue(str[i]) * multiplier + numberInMind;
                result.Add(num % 10);
                numberInMind = num / 10;
            }
            if (numberInMind > 0)
            {
                result.Add(numberInMind);
            }

            result.Reverse();

            Console.WriteLine(string.Join("", result));
        }
    }
}