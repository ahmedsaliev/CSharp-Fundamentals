using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otsechka
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            if (point >= (Math.Min(first, second)) && (point <= Math.Max(first, second)))
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }

            Console.WriteLine(Math.Min(Math.Abs(point - second), Math.Abs(point - first)));
        }
    }
}
