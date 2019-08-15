using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGen
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (var n1 = 1; n1 <= n; n1++)
                for (var n2 = 1; n2 <= n; n2++)
                    for (var l3 = 'a'; l3 < 'a' + l; l3++)
                        for (var l4 = 'a'; l4 < 'a' + l; l4++)
                            for (var n5 = 2; n5 <= n; n5++)
                            {
                                if (n5 > n1 && n5 > n2) Console.Write("{0}{1}{2}{3}{4} ", n1, n2, l3, l4, n5);
                            }
        }
    }
}
