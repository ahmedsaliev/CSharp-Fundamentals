using System;

namespace Problem_09._Melrah_Shake
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (true)
            {
                int firstIndex = text.IndexOf(pattern);
                int lastIndex = text.LastIndexOf(pattern);

                if (firstIndex == -1 || firstIndex == lastIndex || pattern == string.Empty)
                {
                    Console.WriteLine("No shake.");
                    break;
                }

                text = text.Remove(lastIndex, pattern.Length);
                text = text.Remove(firstIndex, pattern.Length);
                pattern = pattern.Remove(pattern.Length / 2, 1);

                Console.WriteLine("Shaked it.");
            }

            Console.WriteLine(text);
        }
    }
}