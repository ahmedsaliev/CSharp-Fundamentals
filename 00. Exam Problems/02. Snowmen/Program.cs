﻿using System;
using System.Linq;

namespace _02._Snowmen
{
    class Program
    {
        static void Main()
        {
            var snowmen = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (snowmen.Count > 1)
            {
                for (int i = 0; i < snowmen.Count; i++)
                {
                    if (snowmen.Count(x => x != -1) == 1)
                    {
                        break;
                    }

                    if (snowmen[i] == -1)
                    {
                        continue;
                    }

                    int attacker = i;
                    int target = snowmen[i] % snowmen.Count;
                    int difference = Math.Abs(attacker - target);

                    if (attacker == target)
                    {
                        //suicide
                        snowmen[attacker] = -1;
                        Console.WriteLine($"{attacker} performed harakiri");
                    }
                    else if (difference % 2 == 0)
                    {
                        //attacker wins
                        snowmen[target] = -1;
                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                    }
                    else
                    {
                        //target wins
                        snowmen[attacker] = -1;
                        Console.WriteLine($"{attacker} x {target} -> {target} wins");
                    }
                }

                snowmen = snowmen.Where(x => x != -1).ToList();
            }
        }
    }
}