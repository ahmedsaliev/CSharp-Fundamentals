using System;

namespace CakeIngredients
{
    class Program
    {
        static void Main()
        {
            string ingredient = null;
            int numberIngredients = 0;

            while (ingredient != "Bake!")
            {
                ingredient = Console.ReadLine();
                if (ingredient != "Bake!")
                {
                    numberIngredients++;
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                }
            }
            Console.WriteLine($"Preparing cake with {numberIngredients} ingredients.");
        }
    }
}