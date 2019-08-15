using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                var commandText = Console.ReadLine().Split(' ').ToList();

                if (commandText[0] == "Delete")
                {
                    int numberToRemove = int.Parse(commandText[1]);
                    {
                        for (int i = 0; i < items.Count; i++)
                        {
                            if (items[i] == numberToRemove)
                            {
                                items.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                    //Console.WriteLine(String.Join(" ", items));
                }
                else if (commandText[0] == "Insert")
                {
                    int numberToInsert = int.Parse(commandText[1]);
                    int positionToInsert = int.Parse(commandText[2]);
                    items.Insert(positionToInsert, numberToInsert);
                    //Console.WriteLine(String.Join(" ", items));
                }
                else if (commandText[0] == "Odd")
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (items[i] % 2 != 0)
                        {
                            Console.Write("{0} ", items[i]);
                        }
                    }
                    return;
                }
                else if (commandText[0] == "Even")
                {
                    for (int i = 1; i < items.Count; i++)
                    {
                        if (items[i] % 2 == 0)
                        {
                            Console.Write("{0} ", items[i]);
                        }
                    }
                    return;
                }
            }
        }
    }
}