using System;
using System.Linq;

namespace _10._Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int difference = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (Math.Abs(array[i] - array[j]) == difference)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
