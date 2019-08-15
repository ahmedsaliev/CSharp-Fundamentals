using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Short_Words_Sorted
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            char[] separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };

            var words = text
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.ToLower())
                .Distinct()
                .Where(s => s.Length < 5)
                .OrderBy(s => s)
                // .ToList();
                .ToArray();

            Console.WriteLine(String.Join(", ", words));
        }
    }
}