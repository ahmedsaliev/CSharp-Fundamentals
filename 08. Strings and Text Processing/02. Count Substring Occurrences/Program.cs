using System;

namespace _02._Count_Substring_Occurrences
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            int count = 0;
            int index = input.IndexOf(pattern, 0);
            while (index >= 0)
            {
                count++;
                index++;
                index = input.IndexOf(pattern, index);
            }
            Console.WriteLine(count);
        }
    }
}