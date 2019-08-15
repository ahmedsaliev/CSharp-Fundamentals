﻿using System;

namespace NeighbourWarsNew
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshosHealth = 100;
            int goshosHealth = 100;
            int turn = 0;

            string winner = null;

            int peshosDamage = int.Parse(Console.ReadLine());
            int goshosDamage = int.Parse(Console.ReadLine());

            while (true)
            {
                turn++;
                if (turn % 2 == 0)
                {
                    peshosHealth -= goshosDamage;
                    if (peshosHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", peshosHealth);
                }
                else
                {
                    goshosHealth -= peshosDamage;
                    if (goshosHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", goshosHealth);
                }
                if (turn % 3 == 0)
                {
                    peshosHealth += 10;
                    goshosHealth += 10;
                }
            }

            if (peshosHealth < goshosHealth)
            {
                winner = "Gosho";
            }
            else
            {
                winner = "Pesho";
            }

            Console.WriteLine($"{winner} won in {turn}th round.");
        }
    }
}
