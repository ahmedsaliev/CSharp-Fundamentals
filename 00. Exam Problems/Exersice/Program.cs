using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Excercise
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 9, 2, 4, 305, 52, 7, 8, 0, 1 };
            var evenNumbers = numbers.Where(x => x % 2 == 0).OrderBy(x => x).Reverse().ToList();
            Console.WriteLine(string.Join(" ", evenNumbers));

            int[] nums = new int[] { 9, 2, 4, 305, 52, 7, 8, 0, 1 };
            var oddNums = nums.Where(x => x % 2 != 0).OrderBy(x => x).Reverse().ToArray();
            Console.WriteLine(string.Join(" ", oddNums));
        }
    }
}