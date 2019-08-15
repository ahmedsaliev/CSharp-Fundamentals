using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Palindromes
{
    class Program
    {
        static string ReverseWord(string word)
        {
            string result = String.Empty;
            for (var i = 0; i < word.Length; i++)
            {
                result = word[i] + result;
            }
            return result;
        }
        static void Main()
            {
            char[] separators = new char[] { ' ', ',', '!', '?', '.' }; 

            string input = Console.ReadLine();

            List<string> wordList = input
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .ToList();

            List<string> palindromes = new List<string>();

            foreach (var word in wordList)
            {
                string a = word;
                string b = ReverseWord(word);
                if (a == b) // (a.CompareTo(b) == 0)
                {
                    palindromes.Add(word);
                }
            }

            palindromes.Sort();

            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}