using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = Console.ReadLine()
                .Split(' ')
                .Select(s => char.Parse(s))
                .ToArray();

            var array2 = Console.ReadLine()
                .Split(' ')
                .Select(s => char.Parse(s))
                .ToArray();

            int minLength = Math.Min(array1.Length, array2.Length);
            int i = 0;

            while (array1[i] == array2[i] && i < minLength - 1)
            {
                i++;
            }

            if (i == minLength - 1)
            {
                if (array1.Length <= array2.Length)
                {
                    foreach (var element in array1)
                    {
                        Console.Write(element);
                    }
                    Console.WriteLine();
                    foreach (var element in array2)
                    {
                        Console.Write(element);
                    }
                    Console.WriteLine();
                }
                else
                {
                    foreach (var element in array2)
                    {
                        Console.Write(element);
                    }
                    Console.WriteLine();
                    foreach (var element in array1)
                    {
                        Console.Write(element);
                    }
                    Console.WriteLine();
                }
            }
            else if (array1[i] < array2[i])
            {
                foreach (var element in array1)
                {
                    Console.Write(element);
                }
                Console.WriteLine();
                foreach (var element in array2)
                {
                    Console.Write(element);
                }
                Console.WriteLine();
            }
            else
            {
                foreach (var element in array2)
                {
                    Console.Write(element);
                }
                Console.WriteLine();
                foreach (var element in array1)
                {
                    Console.Write(element);
                }
                Console.WriteLine();
            }
        }
    }
}