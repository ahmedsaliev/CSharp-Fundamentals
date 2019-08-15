using System;
using System.Text.RegularExpressions;

namespace _03._Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main()
        {
            string pattern = $@"\b(?:0x)?[0-9A-F]+\b";
            string input = Console.ReadLine();
            MatchCollection matchedHex = Regex.Matches(input, pattern);
            foreach (Match name in matchedHex)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}