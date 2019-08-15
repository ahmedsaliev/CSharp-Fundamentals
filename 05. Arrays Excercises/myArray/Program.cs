using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];

            int sum = 0;

            for (var i = 0; i < 10; i++)
            {
                Console.Write("{0:d2} Стойност: ", i + 1);
                myArray[i] = int.Parse(Console.ReadLine());
            }

            for (var j = 0; j < 10; j++)
            {
                sum = sum + myArray[j];
            }

            Console.Write("Сумата на тези числа, Юмерчо, е: {0}", sum);
        }
    }
}
