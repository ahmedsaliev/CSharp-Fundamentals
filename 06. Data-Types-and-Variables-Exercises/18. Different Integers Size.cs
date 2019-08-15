using System;

namespace DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString = Console.ReadLine();

            

            //sbyte < byte < short < ushort < int < uint < long

            sbyte sbyteFitNumber;
            bool sbyteFit = sbyte.TryParse(numberString, out sbyteFitNumber);         

            byte byteFitNumber;
            bool byteFit = byte.TryParse(numberString, out byteFitNumber);

            short shortFitNumber;
            bool shortFit = short.TryParse(numberString, out shortFitNumber);

            ushort ushortFitNumber;
            bool ushortFit = ushort.TryParse(numberString, out ushortFitNumber);

            int intFitNumber;
            bool intFit = int.TryParse(numberString, out intFitNumber);

            uint uintFitNumber;
            bool uintFit = uint.TryParse(numberString, out uintFitNumber);

            long longFitNumber;
            bool longFit = long.TryParse(numberString, out longFitNumber);

            if (!ushortFit && !shortFit && !sbyteFit && !byteFit && !intFit && !uintFit && !longFit)
            {
                Console.WriteLine($"{numberString} can't fit in any type");
            }
            else
            {
                Console.WriteLine($"{numberString} can fit in:");
                if (sbyteFit)
                {
                    Console.WriteLine("* sbyte");
                }
                if (byteFit)
                {
                    Console.WriteLine("* byte");
                }
                if (shortFit)
                {
                    Console.WriteLine("* short");
                }
                if (ushortFit)
                {
                    Console.WriteLine("* ushort");
                }
                if (intFit)
                {
                    Console.WriteLine("* int");
                }
                if (uintFit)
                {
                    Console.WriteLine("* uint");
                }
                if (longFit)
                {
                    Console.WriteLine("* long");
                }
            }
        }
    }
}