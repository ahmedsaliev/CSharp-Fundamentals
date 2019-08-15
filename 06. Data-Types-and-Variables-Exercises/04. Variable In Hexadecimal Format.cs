using System;

namespace VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string hexadecimalNumber = Console.ReadLine();
                Console.WriteLine(Convert.ToInt32(hexadecimalNumber, 16));
            }
            catch
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}