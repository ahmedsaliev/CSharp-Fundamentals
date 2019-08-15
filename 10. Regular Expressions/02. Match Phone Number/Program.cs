using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main()
        {
            string pattern = @"(\+359 2 \d{3} \d{4}\b)|(\+359-2-\d{3}-\d{4}\b)";
            string input = Console.ReadLine();
            MatchCollection matchedPhones = Regex.Matches(input, pattern);
            var phoneNumbers = matchedPhones
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(", ", phoneNumbers));
        }
    }
}