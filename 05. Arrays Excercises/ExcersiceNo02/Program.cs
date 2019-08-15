using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseNo02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            bool flag = true;
            
            //Initialization the firstArray;

            for (var i = 0; i < n; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            //Initialization the secondArray;

            for (var i = 0; i < n; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            //Comparing arrays values;

            for (var i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    flag = false;
                    break;
                }
            }

            //Outputting message;

            if (flag) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
