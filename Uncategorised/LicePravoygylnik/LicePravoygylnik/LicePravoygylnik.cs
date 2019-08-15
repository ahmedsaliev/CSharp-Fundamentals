using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicePravoygylnik
{
    class LicePravoygylnik
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Програма за пресмятане лице на правоъгълник");
            Console.WriteLine("a = ");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("b = ");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Лицето е: " + a * b + " кв. см");
        }
    }
}
