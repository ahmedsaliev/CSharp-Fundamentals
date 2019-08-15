using System;

namespace _04.NumbersInReversedOrder
{
    class Program
    {
        static string ReversedString(string inputString)
        {
            string reversed = null;
            for (int i = 0; i < inputString.Length; i++)
            {
                reversed = inputString[i] + reversed;
            }
            return reversed;
        }

        static void InReversedOrder(decimal a)
        {
            if (a >= 0)
            {
                Console.WriteLine(ReversedString(a.ToString()));
            }
            else
            {
                Console.Write("-");
                a = a * (-1);
                Console.WriteLine(ReversedString(a.ToString()));
            }
        }

        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            InReversedOrder(number);
        }
    }
}
