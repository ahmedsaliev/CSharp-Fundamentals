using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            int n = int.Parse(Console.ReadLine());
            int remainder;
            string binary = string.Empty;
                while (n > 0)
                {
                    remainder = n % 2;
                    n = n / 2;
                    binary = remainder.ToString() + binary;
                }

                Console.WriteLine(binary);
            }
            catch
            {
            }
        }
    }
}
