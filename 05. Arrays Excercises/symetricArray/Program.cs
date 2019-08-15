using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace symetricArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            bool flag = true;

            // Entry array values;
            for (var i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            //Checkign for simetry;

            for (var i = 0; i < n / 2; i++)
            {
                if (array[i] != array[n - i - 1])
                {
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                Console.WriteLine("The array is simetryc!");
            }
            else
            {
                Console.WriteLine("The array isn't simetryc");
            }

            Console.ReadKey(true);
        }
    }
}
