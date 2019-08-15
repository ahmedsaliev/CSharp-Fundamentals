using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04._Force_Book
{
    class Program
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();
            char[] delimiters = new char[] { '|', '-', };


            Dictionary<string, List<string>> forceBook = new Dictionary<string, List<string>>();

            while (inputLine != "end") //Lumpawaroo

            {
                string side = "";
                string user = "";

                if (inputLine.Contains("|"))
                {
                    var inputData = inputLine
                    .Split(new string [] { " | " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();

                    side = inputData[0];
                    user = inputData[1];

                    if (forceBook.ContainsKey(side) == false)
                    {
                        forceBook.Add(side, new List<string>());
                    }

                    bool isRegistered = false;
                    string backSide = "";

                    foreach (var forceUser in forceBook)
                    {
                        if (forceUser.Value.Contains(user))
                        {
                            isRegistered = true;
                            backSide = forceUser.Key;
                        }
                    }

                    if (isRegistered == false)
                    {
                        forceBook[side].Add(user);
                    }
                    else
                    {
                        forceBook[backSide].Remove(user);
                        forceBook[side].Add(user);
                    }
                }
                else if (inputLine.Contains("->"))
                {
                    var inputData = inputLine
                        .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => x.Trim())
                        .ToArray();

                    user = inputData[0];
                    side = inputData[1];

                    if (forceBook.ContainsKey(side) == false)
                    {
                        forceBook.Add(side, new List<string>());
                    }

                    bool isRegistered = false;
                    string backSide = "";

                    foreach (var forceUser in forceBook)
                    {
                        if (forceUser.Value.Contains(user))
                        {
                            isRegistered = true;
                            backSide = forceUser.Key;
                        }
                    }

                    if (isRegistered == true)
                    {
                        forceBook[backSide].Remove(user);
                        forceBook[side].Add(user);

                        if (backSide.CompareTo(side) != 0)
                        {
                            Console.WriteLine($"{user} joins the {side} side!");
                        }
                    }
                    else
                    {
                        forceBook[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }

                inputLine = Console.ReadLine();
            }

            forceBook = forceBook
                .Where(f => f.Value.Count > 0)
                .OrderByDescending(f => f.Value.Count)
                .ThenBy(f => f.Key)
                .ToDictionary(f => f.Key, f => f.Value);

            foreach (var record in forceBook)
            {
                Console.WriteLine($"Side: {record.Key}, Members: {record.Value.Count}");

                foreach (string user in record.Value.OrderBy(u => u))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}