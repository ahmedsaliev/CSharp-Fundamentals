using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine()); //tuhli
            int w = int.Parse(Console.ReadLine()); //rabotnici
            int m = int.Parse(Console.ReadLine()); //vmestimost kolichka

            double count = (double) x / (w * m);
            Console.WriteLine(Math.Ceiling(count));
        }
    }
}
