using System;

public class Program
{
    public static void Main()
    {
        string profession = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());
        double totalPriceWater = quantity * 0.70;
        double totalPriceCoffee = quantity * 1.00;
        double totalPriceBeer = quantity * 1.70;
        double totalPriceTea = quantity * 1.20;

        if (profession == "Athlete")
        {
            Console.WriteLine($"The {profession} has to pay {totalPriceWater:f2}.");
        }
        else if (profession == "Businessman" || profession == "Businesswoman")
        {
            Console.WriteLine($"The {profession} has to pay {totalPriceCoffee:f2}.");
        }
        else if (profession == "SoftUni Student")
        {
            Console.WriteLine($"The {profession} has to pay {totalPriceBeer:f2}.");
        }
        else
        {
            Console.WriteLine($"The {profession} has to pay {totalPriceTea:f2}.");
        }
    }
}