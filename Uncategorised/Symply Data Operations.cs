using System;

namespace SimplyDataOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a++);
            Console.WriteLine(a);

                Console.WriteLine();

            int b = 9;
            Console.WriteLine(++b);
            Console.WriteLine(b);

                Console.WriteLine();

            int c = 5;
            Console.WriteLine(c++ + ++c);
            Console.WriteLine(c);

                Console.WriteLine();

            Console.WriteLine(a++ + ++b);
        }
    }
}
