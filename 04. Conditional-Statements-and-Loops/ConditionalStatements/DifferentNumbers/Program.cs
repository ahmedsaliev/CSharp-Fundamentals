using System;

namespace DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (Math.Abs(a - b) < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (var i = a; i <= b; i++)
                {
                    for (var j = a; j <= b; j++)
                    {
                        for (var k = a; k <= b; k++)
                        {
                            for (var l = a; l <= b; l++)
                            {
                                for (var m = a; m <= b; m++)
                                {
                                    if ((a <= i) && (i < j) && (j < k) && (k < l) && (l < m) && (m <= b))
                                    {
                                        Console.WriteLine("{0} {1} {2} {3} {4}", i, j, k, l, m);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}