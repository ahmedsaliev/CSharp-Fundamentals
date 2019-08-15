using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        while (true)
        {
            List<string> command = Console.ReadLine()
                .Split(' ')
                .ToList();

            switch (command[0])
            {
                case "add":
                    {
                        var index = int.Parse(command[1]);
                        var element = int.Parse(command[2]);
                        numbers.Insert(index, element);
                        break;
                    }
                case "addMany":
                    {
                        var index = int.Parse(command[1]);
                        for (var i = command.Count - 1; i > 1; i--)
                        {
                            var element = int.Parse(command[i]);
                            numbers.Insert(index, element);
                        }
                        break;
                    }
                case "print":
                    Console.WriteLine("[" + string.Join(", ", numbers) + "]");
                    return;
                    break;
                case "contains":
                    {
                        var element = int.Parse(command[1]);
                        if (numbers.Contains(element))
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (element == numbers[i])
                                {
                                    Console.WriteLine(i);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine(-1);
                        }
                        break;
                    }
                case "remove":
                    {
                        var index = int.Parse(command[1]);
                        numbers.RemoveAt(index);
                        break;
                    }
                case "shift":
                    {
                        var position = int.Parse(command[1]);
                        for (var i = 0; i < position; i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                        break;
                    }
                case "sumPairs":
                    {
                        for (var i = 0; i < numbers.Count - 1; i++)
                        {
                            numbers[i] += numbers[i + 1];
                            numbers.RemoveAt(i + 1);
                        }
                        break;
                    }
            }
        }
    }
}