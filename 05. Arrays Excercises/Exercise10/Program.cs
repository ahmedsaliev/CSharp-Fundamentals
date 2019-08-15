using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
  Console.WriteLine("Array's length: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            
            // Array initialization
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0:d2}: ", array[i]);
                array[i] = int.Parse(Console.ReadLine());
            }

            int theNumber = array[0], count = 0;
            for (int i = 0; i < n - 1; i++)
            {
                int counter = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] == array[i])
                    {
                        counter++;
                    }
                }
                if (count < counter)
                {
                    count = counter;
                    theNumber = array[i];
                }
            }

            Console.WriteLine("Most frequent number is {0}.", theNumber);
            Console.WriteLine("It's frequency is {0}.", count);

        }
    }
}
