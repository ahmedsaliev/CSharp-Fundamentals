using System;
using System.Linq;

namespace _02._Baking_Rush
{
    class Program
    {
        static void Main()
        {
            String input = Console.ReadLine();

            String[] commandsList = input
                .Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int counter = 0;
            int energy = 100;
            int coins = 100;

            while (counter != commandsList.Length)
            {
                string[] command = commandsList[counter]
                    .Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int number = int.Parse(command[1]);
                string toDo = command[0];

                // 1. Part

                if (toDo == "rest")
                {
                    if (energy + number >= 100)
                    {
                        Console.WriteLine("You gained {0} energy.", 100 - energy);
                        energy = 100;
                    }
                    else
                    {
                        energy += number;
                        Console.WriteLine("You gained {0} energy.", number);
                    }

                    Console.WriteLine("Current energy: {0}.", energy);
                }

                // 2. Part

                else if (toDo == "order")
                {

                    if (energy >= 30)
                    {
                        Console.WriteLine("You earned {0} coins.", number);
                        coins += number;
                        energy -= 30;
                    }
                    else
                    {
                        Console.WriteLine("You had to rest!");
                        energy += 50;
                    }
                }

                // 3. Part
                else
                {
                    if (coins > number)
                    {
                        Console.WriteLine("You bought {0}.", command[0]);
                        coins -= number;
                    }
                    else
                    {
                        Console.WriteLine("Closed! Cannot afford {0}.", command[0]);
                        break;
                    }
                }

                counter++;
            }

            // 4. Part

            if (counter == commandsList.Length)
            {
                Console.WriteLine("Day completed!");
                Console.WriteLine("Coins: {0}", coins);
                Console.WriteLine("Energy: {0}", energy);
            }
        }
    }
}