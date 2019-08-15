using System;
using System.Text;

namespace PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort start = ushort.Parse(Console.ReadLine());
            ushort end = ushort.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                char c = Convert.ToChar(i);
                Console.Write(c + " ");
            }
        }
    }
}