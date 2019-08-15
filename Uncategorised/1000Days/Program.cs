using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000Days
{
    class Program
    {
        static void Main(string[] args)
        {
            string birthDate = Console.ReadLine();
            var date = DateTime.ParseExact(birthDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime newDate = date.AddDays(999);
            Console.WriteLine(newDate.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture));
        }
    }
}
