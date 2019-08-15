using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            int a = Math.Abs(x3 - x2);
            int h = Math.Abs(y1 - y2);
            double s = (double) a * h / 2;
            Console.WriteLine(s);
        }
    }
}
