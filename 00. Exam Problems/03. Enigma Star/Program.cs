using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _03._Enigma_Star
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> attackePlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            string messagePattern = @"@(?<planet>[a-zA-Z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<attackType>[AD])![^@\-!:>]*->(?<soldiers>\d+)";

            // Calculating the key
            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                int starCount = 0;
                for (int j = 0; j < message.Length; j++)
                {
                    if (message[j] == 's' | message[j] == 'S' |
                        message[j] == 't' | message[j] == 'T' |
                        message[j] == 'a' | message[j] == 'A' |
                        message[j] == 'r' | message[j] == 'R')
                    {
                        starCount++;
                    }
                }

                //Decrypting the message
                StringBuilder encryptedMessage = new StringBuilder();
                for (int j = 0; j < message.Length; j++)
                {
                    char ch = (char)(message[j] - starCount);
                    encryptedMessage.Append(ch);
                }

                Match validMessage = Regex.Match(encryptedMessage.ToString(), messagePattern);

                //Taking planet name
                int index = encryptedMessage.ToString().IndexOf('@') + 1;
                string planetName = String.Empty;
                while (encryptedMessage[index] != ':')
                {
                    if (Char.IsDigit(encryptedMessage[index]) == false)
                        planetName += encryptedMessage[index];
                    index++;
                }

                //Adding planet to the list
                if (encryptedMessage.ToString().Contains("!A!") && validMessage.Success)
                {
                    attackePlanets.Add(planetName);
                }
                else if (encryptedMessage.ToString().Contains("!D!") && validMessage.Success)
                {
                    destroyedPlanets.Add(planetName);
                }
            }

            attackePlanets.Sort();
            //attackePlanets = attackePlanets.Distinct().ToList();
            destroyedPlanets.Sort();
            //destroyedPlanets = destroyedPlanets.Distinct().ToList();

            Console.WriteLine($"Attacked planets: {attackePlanets.Count}");
            for (int i = 0; i < attackePlanets.Count; i++)
            {
                Console.WriteLine($"-> {attackePlanets[i]}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            for (int i = 0; i < destroyedPlanets.Count; i++)
            {
                Console.WriteLine($"-> {destroyedPlanets[i]}");
            }
        }
    }
}