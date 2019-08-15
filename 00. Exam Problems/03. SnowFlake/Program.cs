﻿using System;
using System.Text.RegularExpressions;

namespace _03._SnowFlake
{
    class Program
    {
        static void Main()
        {
            string surface = Console.ReadLine();
            string mantle = Console.ReadLine();
            string middle = Console.ReadLine();
            string secondMantle = Console.ReadLine();
            string secondSurface = Console.ReadLine();

            string surfacePattern = @"[^A-Za-z0-9]+";
            var surfaceRegex = new Regex($"^{surfacePattern}$");

            if (!surfaceRegex.IsMatch(surface))
            {
                Console.WriteLine("Invalid");
                return;
            }
            //It's not necessery when we add ^ and $ to the regex pattern;
            //else
            //{
            //    var match = surfaceRegex.Match(surface);
            //    if (match.Value != surface)
            //    {
            //        Console.WriteLine("Invalid");
            //        return;
            //    }
            //}

            string mantlePattern = @"[\d_]+";
            var mantleRegex = new Regex($"^{mantlePattern}$");

            if (!mantleRegex.IsMatch(mantle))
            {
                Console.WriteLine("Invalid");
                return;
            }

            string corePattern = @"[A-Za-z]+";
            var middleRegex = new Regex($"^{surfacePattern}{mantlePattern}({corePattern}){mantlePattern}{surfacePattern}$");

            if (!middleRegex.IsMatch(middle))
            {
                Console.WriteLine("Invalid");
                return;
            }

            if (!mantleRegex.IsMatch(secondMantle))
            {
                Console.WriteLine("Invalid");
                return;
            }

            if (!surfaceRegex.IsMatch(secondSurface))
            {
                Console.WriteLine("Invalid");
                return;
            }

            Console.WriteLine("Valid");
            var match = middleRegex.Match(middle);
            Console.WriteLine(match.Groups[1].Value.Length);
        }
    }
}