using System;
using System.Linq;
using System.Globalization;


namespace _03._Text_Filter
{
    class Program
    {
        static void Main()
        {
            string[] bannedWords = Console.ReadLine()
                .Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            string inputText = Console.ReadLine();
            foreach (var word in bannedWords)
            {
                string pattern = new string('*', word.Length);
                StringComparison ignoreCase = default(StringComparison);
                inputText = inputText.Replace(word, pattern, ignoreCase);
            }
            Console.WriteLine(inputText);
        }
    }
}