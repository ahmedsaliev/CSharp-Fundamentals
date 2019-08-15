using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flagg;
            int number;
            int lastNumber;
            int n = int.Parse(Console.ReadLine());

            for (var i = 1111; i <= 9999; i++)
            {
                flagg = true;
                number = i;

                for (var j = 1; j <= 4; j++)
                {
                    lastNumber = number % 10;
                    number = number / 10;
                    if (n % lastNumber != 0) flagg = false;
                }

                if (flagg) Console.Write("{0} ", i);
            }
        }
    }
}
