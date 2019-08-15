using System;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char inputChar = char.Parse(Console.ReadLine());
            switch (inputChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    Console.WriteLine("digit");
                    break;
                case 'a':
                case 'o':
                case 'u':
                case 'e':
                case 'i':
                    Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("other");
                    break;
            }
        }
    }
}
