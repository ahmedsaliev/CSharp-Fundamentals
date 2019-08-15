using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoppingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            while (n <= m)
            {
                if ((m % 2 == 0) && (m % 3 == 0) && (m != s))
                    {
                    Console.Write("{0} ", m);
                    }
                if ((m == s) && (m % 2 == 0) && (m % 3 == 0))
                {
                    break;
                }
                else m--;
            }
        }
    }
}
