using System;

namespace GamersHealth
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());
            Console.WriteLine("Name {0}:", name);

            Console.Write("Health: |");
            for (int i = 0; i < currentHealth; i++)
            {
                Console.Write("|");
            }
            for (int j = 0; j < maximumHealth - currentHealth; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine("|");

            Console.Write("Energy: |");
            for (int i = 0; i < currentEnergy; i++)
            {
                Console.Write("|");
            }
            for (int j = 0; j < maximumEnergy - currentEnergy; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine("|");

        }
    }
}
