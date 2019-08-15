using System;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberIngredients = 0;

            for (int i = 0; i < 20; i++)
            {
                string ingredient = Console.ReadLine();

                if (ingredient == "Bake!")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Adding ingredient {0}.", ingredient);
                }
                numberIngredients++;
            }

            Console.WriteLine("Preparing cake with {0} ingredients.", numberIngredients);
        }
    }
}