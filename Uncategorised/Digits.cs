using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int d1 = number / 100;
            int d2 = (number / 10) % 10;
            int d3 = number % 10;
            int n = d1 + d2;
            int m = d1 + d3;

            //Console.Write("{0}, {1}, {2}", d1, d2, d3);

            for (var i = 1; i <= n; i++)
            {
                for (var j = 1; j <= m; j++)
                {
                    if (number % 5 == 0)
                    {
                        number = number - d1;
                        Console.Write("{0} ", number);
                    }
                    else if (number % 3 == 0)
                    {
                        number = number - d2;
                        Console.Write("{0} ", number);
                    }
                    else
                    {
                        number = number + d3;
                        Console.Write("{0} ", number);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
