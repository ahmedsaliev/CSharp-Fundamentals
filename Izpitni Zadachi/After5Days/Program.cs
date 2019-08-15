using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After5Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            DateTime date1 = new DateTime(2018, m, d);
            DateTime date2 = date1.AddDays(5);

            //if (date2.Month > 9) Console.WriteLine(date2.Day + "." + date2.Month);
            //else Console.WriteLine(date2.Day + ".0" + date2.Month);

            Console.WriteLine("{0}.{1:D2}", date2.Day, date2.Month);
        }
    }
}
