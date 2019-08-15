using System;

namespace VariableOverflowChecking
{
    class Program
    {
        static void Main()
        {
            //Throw exception and stop working
            checked
            {
                int a = int.MaxValue;
                a = a + 1;
                Console.WriteLine(a);
            }
        }
    }
}
