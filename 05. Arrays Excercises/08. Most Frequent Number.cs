using System;

namespace _08._Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numsText = Console.ReadLine()
                .Split(' ');
            int[] array = new int[numsText.Length];

            for (int i = 0; i < numsText.Length; i++)
            {
                array[i] = int.Parse(numsText[i]);
            }

            int n = numsText.Length;
            int theNumber = array[0], count = 0;
            for (int i = 0; i < n - 1; i++)
            {
                int counter = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] == array[i])
                    {
                        counter++;
                    }
                }
                if (count < counter)
                {
                    count = counter;
                    theNumber = array[i];
                }
            }
            Console.WriteLine(theNumber);
        }
    }
}
