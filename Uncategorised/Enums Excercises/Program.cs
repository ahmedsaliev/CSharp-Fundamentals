using System;

namespace Enums
{
    class Program
    {
        public enum Day
        {
            Monday = 1, //By default is 0;
            Tuesday,
            Wednsday,
            Thusday,
            Friday,
            Saturday,
            Sunday
        }

        public enum CoffeeSize
        {
            Small = 150,
            Medium = 250,
            Large = 350
        }

        public enum Season
        {
            Spring = 2,
            Summer = 4,
            Autumn = 1,
            Winter = 3
        }

        public enum Discount
        {
            None,
            SecondVisit = 10,
            VIP = 20
        }

        static void Main()
        {
            Console.WriteLine(Day.Friday + 2);
            Console.WriteLine(CoffeeSize.Large);
        }  
    }
}