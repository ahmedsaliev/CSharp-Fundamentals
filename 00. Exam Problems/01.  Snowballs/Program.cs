using System;
using System.Numerics;

namespace _01.__Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger value = 0;

            int snowMax = 0;
            int timeMax = 0;
            int qualityMax = 0;
            BigInteger valueMax = 0;

            for (int i = 0; i < n; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                if (time != 0)
                {
                value = BigInteger.Pow((snow / time), quality);
                }

                if (value > valueMax)
                {
                    snowMax = snow;
                    timeMax = time;
                    qualityMax = quality;
                    valueMax = value;
                }
            }

            Console.WriteLine($"{snowMax} : {timeMax} = {valueMax} ({qualityMax})");
        }
    }
}