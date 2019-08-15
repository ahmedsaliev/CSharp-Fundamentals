using System;
using System.Collections.Generic;
using System.Linq;

namespace _00._Sort_List
{
    class Program
    {
        static void Main()
        {
            List<string> listOfNames = new List<string>();

            listOfNames = "Ahmed Omer Fatma Zekie"
                .Split()
                .ToList();
            listOfNames.Sort();

            Console.WriteLine(string.Join(", ", listOfNames));

            listOfNames.Reverse();
            Console.WriteLine(new string('–', 35));

            Console.WriteLine(string.Join(", ", listOfNames));
            Console.WriteLine(new string('–', 35));

            listOfNames = listOfNames.Select(x => x.ToLower()).ToList();
            Console.WriteLine(string.Join(", ", listOfNames));
            Console.WriteLine(new string('–', 35));
        }
    }
}