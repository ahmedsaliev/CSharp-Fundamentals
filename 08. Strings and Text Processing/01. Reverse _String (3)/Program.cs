using System;
using System.Linq;

namespace _01._Reverse__String__3_
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();
            string reversed = new string(line.Reverse().ToArray());
            Console.WriteLine($"{line} --> {reversed}");
        }
    }
}
