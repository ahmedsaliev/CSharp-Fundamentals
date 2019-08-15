using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int[] len = new int[n];

            //Array initialization

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
