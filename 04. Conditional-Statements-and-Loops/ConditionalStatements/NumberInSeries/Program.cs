using System;

namespace NumberInSeries
{
    class Program
    {
        static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int maxNumber = Math.Max(number1, number2);
            int minNumber = Math.Min(number1, number2);

            for (int i = minNumber; i <= maxNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
