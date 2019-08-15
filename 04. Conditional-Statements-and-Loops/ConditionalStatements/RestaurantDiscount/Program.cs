using System;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main()
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            int normalPackage = 500;
            int goldenPackage = 750;
            int platinumPackage = 1000;
            int priceSmallHall = 2500;
            int priceTerrace = 5000;
            int priceGreatHall = 7500;
            string hallName = "";
            bool flagg = true;
            double price = 0;

            if ((groupSize > 0) && (groupSize <= 50))
            {
                hallName = "Small Hall";
                price = priceSmallHall;
            }
            else if (groupSize <= 100)
            {
                hallName = "Terrace";
                price = priceTerrace;
            }
            else if (groupSize <= 120)
            {
                hallName = "Great Hall";
                price = priceGreatHall;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                flagg = false;
            }

            if (flagg)
            {
                if (package == "Normal")
                {
                    price = (price + normalPackage) * 0.95;
                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {price / groupSize:f2}$");
                }
                else if (package == "Gold")
                {
                    price = (price + goldenPackage) * 0.9;
                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {price / groupSize:f2}$");
                }
                else
                {
                    price = (price + platinumPackage) * 0.85;
                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {price / groupSize:f2}$");
                }
            }
        }
    }
}
