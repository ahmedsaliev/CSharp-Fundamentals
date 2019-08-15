using System;

namespace _01._Baking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());

            double price = apronPrice * (students + Math.Ceiling(students * 0.2)) +
                eggPrice * 10 * students + flourPrice * (students - (int)(students / 5));

            if (price <= budget) Console.WriteLine("Items purchased for {0:f2}$.", price);
            else Console.WriteLine("{0:f2}$ more needed.", price - budget);
        }
    }
}