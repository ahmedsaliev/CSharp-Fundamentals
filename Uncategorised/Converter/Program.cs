using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {
        static void Main()
        {
            string usd = "USD", bgn = "BGN", eur = "EUR", gbp = "GBP";
            var pari = double.Parse(Console.ReadLine());
            double leva = 0.0;

            var valuta1 = Console.ReadLine();
            var valuta2 = Console.ReadLine();

            if (usd.Equals(valuta1)) leva = pari * 1.79549;
            if (eur.Equals(valuta1)) leva = pari * 1.95583;
            if (gbp.Equals(valuta1)) leva = pari * 2.53405;
            if (bgn.Equals(valuta1)) leva = pari;

            if (usd.Equals(valuta2)) Console.WriteLine(Math.Round((leva / 1.79549), 2) + " USD");
            if (eur.Equals(valuta2)) Console.WriteLine(Math.Round((leva / 1.95583), 2) + " EUR");
            if (gbp.Equals(valuta2)) Console.WriteLine(Math.Round((leva / 2.53405), 2) + " GBP");
            if (bgn.Equals(valuta2)) Console.WriteLine(Math.Round(leva, 2) + " BGN");
        }
    }
}
