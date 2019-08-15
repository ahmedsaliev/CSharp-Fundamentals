using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseNo01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];

            for (var i = 0; i < 20; i++)
            {
                array[i] = i * 5;
                Console.Write("{0} ", array[i]);
            }

            Console.WriteLine();
        }
    }
}
