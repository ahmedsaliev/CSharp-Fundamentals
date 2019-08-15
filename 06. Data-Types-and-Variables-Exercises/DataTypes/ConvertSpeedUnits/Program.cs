using System;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main()
        {
            UInt32 meters = UInt32.Parse(Console.ReadLine());
            byte hours = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());

            int totalSeconds = (int)(hours * 3600 + minutes * 60 + seconds);
            float metersPerSec = (float)meters / (float)totalSeconds;
            float kilometresPerHour = ((float)meters / 1000) / ((float)totalSeconds / 3600);
            float milesPerHour = ((float)meters / 1609) / ((float)totalSeconds / 3600);

            Console.WriteLine("{0:f6}", metersPerSec);
            Console.WriteLine("{0:0.######}", kilometresPerHour);
            Console.WriteLine("{0:f6}", milesPerHour);

        }
    }
}
