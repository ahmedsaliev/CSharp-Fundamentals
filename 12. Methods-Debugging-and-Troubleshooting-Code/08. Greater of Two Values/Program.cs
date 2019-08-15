using System;

namespace _08._Greater_of_Two_Values
{
    class Program
    {
        static int GetMax(int x, int y)
        {
            if (x >= y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }

        static char GetMax(char x, char y)
        {
            if (x >= y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }

        static string GetMax(string x, string y)
        {
            if (x.CompareTo(y) >= 0)
            {
                return x;
            }
            else
            {
                return y;
            }
        }

        static void Main(string[] args)
        {
            string dataType = Console.ReadLine().ToLower();
            switch (dataType)
            {
                case "int":
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(num1, num2));
                    break;
                case "char":
                    char char1 = char.Parse(Console.ReadLine());
                    char char2 = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(char1, char2));
                    break;
                case "string":
                    string string1 = Console.ReadLine();
                    string string2 = Console.ReadLine();
                    Console.WriteLine(GetMax(string1, string2));
                    break;
                default:
                    break;
            }
        }
    }
}
