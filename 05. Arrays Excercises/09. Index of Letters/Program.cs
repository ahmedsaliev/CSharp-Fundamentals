using System;
using System.Linq;

namespace _09._Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var englishLetters = "a b c d e f g h i j k l m n o p q r s t u v w x y z"
                                .Split(' ')
                .Select(s => char.Parse(s)).ToArray();
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < englishLetters.Length; j++)
                {
                    if (input[i] == englishLetters[j])
                    {
                        Console.WriteLine($"{input[i]} -> {j}");
                    }
                }
            }
        }
    }
}
