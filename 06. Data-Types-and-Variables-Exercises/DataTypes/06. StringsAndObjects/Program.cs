using System;

namespace _06._StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            int temporaryNumber;

            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            temporaryNumber = a;
            a = b;
            b = temporaryNumber;
        }
    }
}
