using System;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            bool flag = false;
            int counter = 0;
            int totalNumber = 0;
            int firstNumber = 0, secondNumber = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    totalNumber++;
                    sum = i + j;
                    if (sum == magicalNumber)
                    {
                        flag = true;
                        counter++;
                        firstNumber = i;
                        secondNumber = j;
                        
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("Number found! {0} + {1} = {2}", firstNumber, secondNumber, magicalNumber);
            }
            else
            {
                Console.WriteLine("{0} combinations - neither equals {1}", totalNumber, magicalNumber);
            }
        }
    }
}
