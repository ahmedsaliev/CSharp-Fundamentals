using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_03._Unicode_Characters
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();

            foreach (var ch in line)
            {
                Console.WriteLine("\\u" + ((int)ch).ToString("x4"));
                List<int> list = new List<int>();
                Console.WriteLine("\\u{0:x4}", (int)ch);
            }
        }
    }
}