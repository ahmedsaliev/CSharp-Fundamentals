using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n = ");
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the numbers:");

            var max = int.Parse(Console.ReadLine());


            for (int i = 2; i <= n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (max < number) max = number;
            }

            Console.WriteLine("Max = " + max);
        }
    }
}
