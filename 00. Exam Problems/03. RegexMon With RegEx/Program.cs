using System;
using System.Text.RegularExpressions;

namespace _03._RegexMon_With_RegEx
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string didiPattern = @"[^A-Za-z-]+";
            string bojoPattern = @"[A-Za-z]+-[A-Za-z]+";

            int round = 1;

            while (true)
            {
                if (round % 2 == 1)
                {
                    if (!Regex.IsMatch(input, didiPattern))
                    {
                        return;
                    }
                    else
                    {
                        Match current = Regex.Match(input, didiPattern);
                        input = input.Substring(current.Index + current.Length);
                        Console.WriteLine(current.ToString());
                    }
                }
                else
                {
                    if (!Regex.IsMatch(input, bojoPattern))
                    {
                        return;
                    }
                    else
                    {
                        Match current = Regex.Match(input, bojoPattern);
                        input = input.Substring(current.Index + current.Length);
                        Console.WriteLine(current.ToString());
                    }
                }

                round++;
            }
        }
    }
}