﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] *= 2;
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}