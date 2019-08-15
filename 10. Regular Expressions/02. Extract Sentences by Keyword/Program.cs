using System;
using System.Text.RegularExpressions;

namespace _02._Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();
            string pattern = $@"\b[^?.!]*\b{keyWord}\b[^?.!]*";
            string input = Console.ReadLine();
            MatchCollection sentences = Regex.Matches(input, pattern);
            foreach (Match sentence in sentences)
            {
                Console.WriteLine(sentence.Value);
            }
        }
    }
}