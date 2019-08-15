using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Split_by_Word_Casing
{
    class Program
    {
        static void Main()
        {
            string inputText = Console.ReadLine();

            char[] separators = new char[] { ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']', ' ' };

            string[] textArray = inputText
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            foreach (var word in textArray)
            {
                int lowerCount = 0;
                int upperCount = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    if (Char.IsLower(word[i]))
                    {
                        lowerCount++;
                    }
                    else if (Char.IsUpper(word[i]))
                    {
                        upperCount++;
                    }
                }

                if (lowerCount == word.Length)
                {
                    lowerCase.Add(word);
                }
                else if (upperCount == word.Length)
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }

            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCase));
        }
    }
}