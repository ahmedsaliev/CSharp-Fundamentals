using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            char inputChar = char.Parse(Console.ReadLine());
            int position = inputString.IndexOf(inputChar);

            if (position >= 0)
            {
                Console.WriteLine("Contained in position {0}!", position + 1);
            }
            else
            {
                Console.WriteLine("Not contained!");
            }
        }
    }
}
