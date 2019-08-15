using System;

namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string attackingPlayer = null;
            string attack = null;
            string defendingPlayer = null;
            string winner = null;

            int peshosHealth = 100;
            int goshosHealth = 100;
            int defendingPlayerHealth = 0;
            int peshosDamage = int.Parse(Console.ReadLine());
            int goshosDamage = int.Parse(Console.ReadLine());
            int turn = 0;

            if ((peshosDamage > 0) || (goshosDamage > 0))
            {
                while ((peshosHealth > 0) && (goshosHealth > 0))
                {
                    turn++;

                    if (turn % 2 == 0)
                    {
                        attackingPlayer = "Gosho";
                        attack = "Thunderous fist";
                        defendingPlayer = "Pesho";
                        peshosHealth = peshosHealth - goshosDamage;
                        defendingPlayerHealth = peshosHealth;
                    }
                    else
                    {
                        attackingPlayer = "Pesho";
                        attack = "Roundhouse kick";
                        defendingPlayer = "Gosho";
                        goshosHealth = goshosHealth - peshosDamage;
                        defendingPlayerHealth = goshosHealth;
                    }

                    if ((turn % 3 == 0) && (defendingPlayerHealth) > 0)
                    {
                        peshosHealth += 10;
                        goshosHealth += 10;
                    }

                    if (defendingPlayerHealth > 0)
                    {
                        Console.WriteLine($"{attackingPlayer} used {attack} and reduced {defendingPlayer} to {defendingPlayerHealth} health.");
                    }
                }

                if (peshosHealth < 0)
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
}