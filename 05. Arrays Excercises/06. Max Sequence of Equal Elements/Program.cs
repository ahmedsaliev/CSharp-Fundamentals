﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestLength
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                            .Split(' ')
                            .Select(s => int.Parse(s))
                            .ToArray();

            int length = 1;
            int bestStart = 0;
            int bestLength = 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    length++;
                    if (length > bestLength)
                    {
                        bestLength = length;
                        bestStart = i;
                    }
                }
                else
                {
                    length = 1;
                }
            }

            //Result printing

            for (int i = 0; i < bestLength; i++)
            {
                Console.Write("{0} ", array[bestStart]);
            }
        }
    }
}