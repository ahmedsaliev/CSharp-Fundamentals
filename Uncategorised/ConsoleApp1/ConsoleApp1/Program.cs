using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Drawing the first row...
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 2 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            
            //Drawing the middle row...
            Console.Write("+");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(" +");
            }
            Console.WriteLine();

            //Drawing the last row...
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" +");
                }
                Console.WriteLine();
            }
        }
    }
}
