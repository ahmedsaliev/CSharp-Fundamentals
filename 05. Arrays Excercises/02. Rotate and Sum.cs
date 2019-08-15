using System;
using System.Linq;

namespace _02._Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            int[] sumArray = new int[array.Length];
            int k = int.Parse(Console.ReadLine());

            for (int j = 0; j < k; j++)
            {
                int tempNumber = array[array.Length - 1];
                for (int i = array.Length - 1; i > 0; i--)
                {
                    array[i] = array[i - 1];
                    sumArray[i] += array[i];
                }
                array[0] = tempNumber;
                sumArray[0] += array[0];
            }

            foreach (int i in sumArray)
            {
                Console.Write(i + " ");
            }
        }
    }
}
