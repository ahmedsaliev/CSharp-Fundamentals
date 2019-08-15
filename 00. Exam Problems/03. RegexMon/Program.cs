using System;
using System.Text.RegularExpressions;

namespace _03._RegexMon
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            while (input != String.Empty)
            {
                string result = String.Empty;
                int index = 0;

                while (index < input.Length && !(Char.IsLetter(input[index]) | input[index] == '-'))
                {
                    result += input[index];
                    index++;
                }

                input = input.Remove(0, index);
                if (result != String.Empty)
                {
                Console.WriteLine(result);
                }

                result = String.Empty;
                index = 0;

                while (index < input.Length && (Char.IsLetter(input[index]) | input[index] == '-'))
                {
                    result += input[index];
                    index++;
                }

                input = input.Remove(0, index);
                result = result.Trim('-');
                if (result.Contains("-"))
                {
                    Console.WriteLine(result);
                }
                else
                {
                    index = 0;
                    while (index < input.Length && !(Char.IsLetter(input[index]) | input[index] == '-'))
                    {
                        result += input[index];
                        index++;
                    }
                    input = input.Remove(0, index);
                }
            }
        }
    }
}