using System;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            HelloName(name);
        }

        static void HelloName(string userName)
        {
            Console.WriteLine($"Hello, {userName}!");
        }
    }
}