using System;

namespace _05._Fibonacci_Numbers
{
    class Program
    {
        static int FibonacciNumber(int number)
        {
            int fib1 = 1;
            int fib2 = 1;
            if (number == 0 || number == 1)
            {
                return 1;
            }
            else
            {
                int fibonacciNumber = 0;
                for (int i = 2; i <= number; i++)
                {
                    fibonacciNumber = fib1 + fib2;
                    fib1 = fib2;
                    fib2 = fibonacciNumber;
                }
                return fibonacciNumber;
            }

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciNumber(n));
        }
    }
}
