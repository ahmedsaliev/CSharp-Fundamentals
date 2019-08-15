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
            int index = 0;

            while (true)
            {
                index = input.IndexOf(pattern, index);
                if (index < 0)
                {
                    break;
                }
                count++;
                index++;
            }
            Console.WriteLine(count);
        }
    }
}