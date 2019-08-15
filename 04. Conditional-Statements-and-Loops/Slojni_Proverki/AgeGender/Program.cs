using System;

class Program
{
        static void Main()
        {
        var age = double.Parse(Console.ReadLine());
        var gender = Console.ReadLine().ToLower();
        if (age < 16)
        {
            if (gender == "m") Console.WriteLine("Master");
            else Console.WriteLine("Miss");
        }
        else
            {
            if (gender == "m") Console.WriteLine("Mr.");
            else Console.WriteLine("Ms.");
        }
        }
}
