using System;
using System.Linq;

namespace NumbersSum
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[] { 1, 5, 3, 2 };

            Console.WriteLine("Sum is: {0}", array.Sum());
            Console.WriteLine("Max is: {0}", array.Max());
            Console.WriteLine(string.Join(" ", array));

            var first = array.First();
            Console.WriteLine(first);
        }
    }
}
