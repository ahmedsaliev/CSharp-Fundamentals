using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isHolding = false;
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num.ToString().Length; i++)
            {
                if (num % 10 == 0)
                {
                    isHolding = true;
                    break;
                }
                else
                {
                    num = num / 10;
                }
            }
            Console.WriteLine(isHolding);
        }
    }
}
