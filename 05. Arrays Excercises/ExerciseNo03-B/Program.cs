using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseNo03_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstArrayString = null;
            string secondArrayString = null;


            //Initializing the first array

            Console.Write("Length of the first array: ");
            int length1 = int.Parse(Console.ReadLine());
            char[] firstArray = new char[length1];

            for (var i = 0; i < length1; i++)
            {
                firstArray[i] = char.Parse(Console.ReadLine());
                firstArrayString = firstArrayString + firstArray[i];
            }

            //Initializing the second array

            Console.Write("Length of the first array: ");
            int length2 = int.Parse(Console.ReadLine());
            char[] secondArray = new char[length2];

            for (var i = 0; i < length2; i++)
            {
                secondArray[i] = char.Parse(Console.ReadLine());
                secondArrayString = secondArrayString + secondArray[i];
            }

            //Strings compairing
            if (string.Compare(firstArrayString, secondArrayString) < 0)
            {
                Console.WriteLine("The first array is earlier!");
            }
            else if (string.Compare(firstArrayString, secondArrayString) == 0)
            {
                Console.WriteLine("The arrays are equal!");
            }
            else
            {
                Console.WriteLine("The second array is earlier!");
            }
        }
    }
}
