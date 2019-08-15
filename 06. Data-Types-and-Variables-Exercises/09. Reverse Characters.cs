using System;

namespace ReverseCharacters
{
    class Program
    {
        static void Main()
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letter3 = char.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{2}", letter3, letter2, letter1);
        }
    }
}
