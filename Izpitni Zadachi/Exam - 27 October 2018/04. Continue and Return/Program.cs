using System;

namespace _04._Continue_and_Return
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("Hello!");
        }
    }
}
