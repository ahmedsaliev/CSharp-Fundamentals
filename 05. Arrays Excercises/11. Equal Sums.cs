using System;
using System.Linq;

namespace _11._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            bool flag = false;

            if (array.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }
            else if (array.Length == 2)
            {
                Console.WriteLine("no");
                return;
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    double leftSum = 0;
                    double rigthSum = 0;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        rigthSum += array[j];
                    }
                    for (int j = i - 1; j >= 0; j--)
                    {
                        leftSum += array[j];
                    }
                    if (leftSum == rigthSum)
                    {
                        flag = true;
                        Console.WriteLine(i);
                        return;
                    }
                }
            }
            if (!flag)
            {
                Console.WriteLine("no");
            }
        }
    }
}