using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;

namespace _00._Excersices
{
    class Program
    {
        class Dragon
        {
            public string Name { get; set; }
            public int Damage { get; set; }
        }

        static void Main()
        {
            List<int> list = new List<int>() { 1, 1, 2, 3, 5, 5, 5, 8 };
            list = list.Distinct().Reverse().ToList();
            list = list.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", list));

            Console.WriteLine(new string('-', 40));

            string line = "BoabaB";
            string reversed = new string(line.Reverse().ToArray());
            Console.WriteLine($"{line} --> {reversed}");

            Console.WriteLine(new string('-', 40));

            BigInteger number = new BigInteger(10); //number = 10;
            byte pow = 5;
            BigInteger result = BigInteger.Pow(number, pow);
            Console.WriteLine("{0}^{1} = {2}", number, pow, result);

            Console.WriteLine(new string('-', 40));

            Dragon dragon = new Dragon();
            dragon.Name = "Zohan";
            dragon.Damage = 100;

            List<Dragon> dragons = new List<Dragon>();
        }
    }
}