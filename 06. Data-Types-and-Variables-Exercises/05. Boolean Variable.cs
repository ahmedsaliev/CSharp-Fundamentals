using System;

namespace BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            if (Convert.ToBoolean(inputText))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }            
        }
    }
}
