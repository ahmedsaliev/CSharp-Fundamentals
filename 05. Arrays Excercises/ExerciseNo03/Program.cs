using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseNo03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing the first array

            Console.Write("Length of the first array: ");
            bool flag = false;
            int length1 = int.Parse(Console.ReadLine());
            char[] firstArray = new char[length1];

            for (var i = 0; i < length1; i++)
            {
                firstArray[i] = char.Parse(Console.ReadLine());
            }

            //Initializing the second array

            Console.Write("Length of the first array: ");
            int length2 = int.Parse(Console.ReadLine());
            int index = Math.Min(length1, length2);
            char[] secondArray = new char[length2];

            for (var i = 0; i < length2; i++)
            {
                secondArray[i] = char.Parse(Console.ReadLine());
            }

            //Lexical compairing of the arrays

            for (var i = 0; i < index; i++)
            {
                    if (firstArray[i] < secondArray[i])
                    {
                        flag = true;
                        Console.WriteLine("The first array is earlier!");
                        break;
                    }
                    else if (firstArray[i] > secondArray[i])
                    {
                        flag = true;
                        Console.WriteLine("The second array is earlier!");
                        break;
                    }
            }

            if (!flag && (length1 < length2)) Console.WriteLine("The first array is earlier!");
            else if (!flag && (length2 < length1)) Console.WriteLine("The second array is earlier!");
            else if (!flag && (length1 == length2)) Console.WriteLine("The arrays are equal!");
        }
    }
}
