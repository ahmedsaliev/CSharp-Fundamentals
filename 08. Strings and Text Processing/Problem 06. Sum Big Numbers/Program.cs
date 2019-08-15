﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_06._Sum_Big_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string str1 = Console.ReadLine().TrimStart('0');
            string str2 = Console.ReadLine().TrimStart('0');

            if (str1 == string.Empty) str1 = "0";
            if (str1 == string.Empty) str1 = "0";
            
            //Console.WriteLine(str1);
            //Console.WriteLine(str2);

            int length = Math.Max(str1.Length, str2.Length);

            if (str1.Length < length)
            {
                string zeroes = new string('0', length - str1.Length);
                str1 = zeroes + str1;
            }
            else if (str2.Length < length)
            {
                string zeroes = new string('0', length - str2.Length);
                str2 = zeroes + str2;
            }

            List<int> result = new List<int>();
            int rest = 0;

            for (int i = length - 1; i >= 0; i--)
            {
                int sum = rest + (int)Char.GetNumericValue(str1[i]) + (int)Char.GetNumericValue(str2[i]);
                if (sum > 9)
                {
                    result.Add(sum % 10);
                    rest = 1;
                }
                else
                {
                    result.Add(sum);
                    rest = 0;
                }
            }

            if (rest == 1)
            {
                result.Add(1);
            }
            result.Reverse();

            Console.WriteLine(string.Join("", result));
        }
    }
}