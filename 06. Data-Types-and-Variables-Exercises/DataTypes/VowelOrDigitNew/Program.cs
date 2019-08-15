using System;

namespace VowelOrDigitNew
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputChar = Console.ReadLine();
            int number;
            bool isDigit = int.TryParse(inputChar, out number);
            bool isVowel = "aeiouAEIOU".IndexOf(inputChar) >= 0;

            if (isDigit)
            {
                Console.WriteLine("digit");
            }
            else if (isVowel)
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
