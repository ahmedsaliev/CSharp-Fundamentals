using System;
using System.Text.RegularExpressions;

namespace _05._Match_Numbers
{
    class Program
    {
        static void Main()
        {
            string rgx = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            string numbersString = Console.ReadLine();
            var numbers = Regex.Matches(numbersString, rgx);
            foreach (Match number in numbers)
            {
                Console.Write(number.Value + " ");
            }
            Console.WriteLine();
        }
    }
}