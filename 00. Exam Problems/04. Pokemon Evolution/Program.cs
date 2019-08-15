using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _04._Pokemon_Evolution
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string evolution = "";
            string name = "";

            Dictionary<string, List<string>> pokemons = new Dictionary<string, List<string>>();

            while (input[0] != "wubbalubbadubdub")
            {
                if (input.Length > 1)
                {
                    name = input[0];
                    evolution = input[1] + " <-> " + input[2];
                    if (!pokemons.ContainsKey(name))
                    {
                        List<string> currentList = new List<string> { evolution };
                        pokemons.Add(name, currentList);
                    }
                    else
                    {
                        pokemons[name].Add(evolution);
                    }
                }
                else
                {
                    name = input[0];
                    if (pokemons.ContainsKey(name))
                    {
                        Console.WriteLine($"# {name}");
                        foreach (var status in pokemons[name])
                        {
                            Console.WriteLine($"{status}");
                        }
                    }
                }

                input = Console.ReadLine().Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            //Result printing

            foreach (var pair in pokemons)
            {
                Console.WriteLine($"# {pair.Key}");
                foreach (var status in pair.Value.OrderByDescending(x => int.Parse(x.Split(new char[] { '<', '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries).Skip(1).First()))) //.Last() <-> Skip(1).First()
                {
                    Console.WriteLine($"{status}");
                }
            }
        }
    }
}