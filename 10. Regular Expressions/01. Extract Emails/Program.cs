using System;
using System.Text.RegularExpressions;

namespace _01._Extract_Emails
{
    class Program
    {
        static void Main()
        {
            string pattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-_][A-Za-z]+)+))(\b|(?=\s))";
            string input = Console.ReadLine();
            MatchCollection eMails = Regex.Matches(input, pattern);
            foreach (Match email in eMails)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}