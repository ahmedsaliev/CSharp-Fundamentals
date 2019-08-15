using System;

namespace Pluralize
{
    class Program
    {
        static void Main()
        {
            string noun = Console.ReadLine();
            string nounInPlural = null;

            if (noun.EndsWith("y"))
            {
                nounInPlural = noun.Remove(noun.Length - 1);
                Console.WriteLine(nounInPlural + "ies");
            }
            else if (noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s") || noun.EndsWith("sh") ||
                noun.EndsWith("x") || noun.EndsWith("z"))
            {
                Console.WriteLine(noun + "es");
            }
            else
            {
                Console.WriteLine(noun + "s");
            }
        }
    }
}