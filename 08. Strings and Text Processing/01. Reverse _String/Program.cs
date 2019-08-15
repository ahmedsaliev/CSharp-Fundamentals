using System;

namespace _01._Reverse__String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = String.Empty;
            for (var i = 0; i < input.Length; i++)
            {
                result = input[i] + result;
            }
            Console.WriteLine(result);
        }
    }
}