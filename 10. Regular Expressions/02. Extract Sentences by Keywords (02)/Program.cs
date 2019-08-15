using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();
            string pattern = $@"\b\b{keyWord}\b";
            string[] sentences = Console.ReadLine()
                .Split(new char[] { '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            foreach (string sentence in sentences)
            {
                if (Regex.IsMatch(sentence, pattern))
                {
                Console.WriteLine(sentence);
                //Console.WriteLine(sentence.Trim())
                }
            }
        }
    }
}