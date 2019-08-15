using System;

namespace _01._Charity_Marathon
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            int laps = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());

            long totalRunners = Math.Min(capacity * days, runners);
            long totalMeters = totalRunners * laps * length;
            double totalKilometres = totalMeters * 1.0 / 1000;
            double moneyRaised = totalKilometres * money;

            Console.WriteLine("Money raised: {0:f2}", moneyRaised);
        }
    }
}