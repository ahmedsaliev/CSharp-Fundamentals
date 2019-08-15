using System;
using System.Linq;
using System.Collections.Generic;

namespace _00._Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] == 0)
                {
                    items.RemoveAt(i);
                }
            }
            Console.WriteLine(String.Join(" ", items));
        }
    }
}
}
