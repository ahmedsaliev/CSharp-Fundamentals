using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reading the array elements
            var array = Console.ReadLine()
                .Split(' ')
                .Select(s => int.Parse(s))
                .ToArray();

            //Folding
            int[] reversedArray = new int[array.Length / 2];
            for (int i = 0; i < array.Length / 4; i++)
            {
                reversedArray[i] = array[array.Length / 4 - i - 1];
                reversedArray[array.Length / 4 + i] = array[array.Length - i - 1];
            }

            //Finding the sum
            int[] sumArray = new int[array.Length / 2];

            for (int i = 0; i < array.Length / 2; i++)
            {
            sumArray[i] = reversedArray[i] + array[array.Length / 4 + i];
            }

            //Printing the result
            foreach (var element in sumArray)
            {
                Console.Write(element + " ");
            }
        }
    }
}