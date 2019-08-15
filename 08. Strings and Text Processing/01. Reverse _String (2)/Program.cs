using System;
using System.Linq;

namespace _01._Reverse__String
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] result = input.ToCharArray().Reverse().ToArray();
            Console.WriteLine(result);
        }
    }
}