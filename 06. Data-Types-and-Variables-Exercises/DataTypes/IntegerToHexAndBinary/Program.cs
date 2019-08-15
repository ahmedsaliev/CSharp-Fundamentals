using System;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            //To HEX
            string hex = Convert.ToString(inputNumber, 16);
            Console.WriteLine(hex.ToUpper());

            //To binary
            string binary = Convert.ToString(inputNumber, 2);
            Console.WriteLine(binary);
        }
    }
}