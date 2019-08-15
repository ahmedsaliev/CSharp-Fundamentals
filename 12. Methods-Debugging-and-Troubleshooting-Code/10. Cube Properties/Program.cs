using System;

namespace _10._Cube_Properties
{
    class Program
    {
        static double FaceDiagonalOfCube(double x)
        {
            double faceDiagonal = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(x, 2));
            return faceDiagonal;
        }

        static double SpaceDiagonalOfCube(double x)
        {
            double spaceDiagonal = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(FaceDiagonalOfCube(x), 2));
            return spaceDiagonal;
        }

        static double VolumeOfCube(double x)
        {
            double volume = Math.Pow(x, 3);
            return volume;
        }

        static double AreaOfCube(double x)
        {
            double area = 6 * Math.Pow(x, 2);
            return area;
        }

        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            string property = Console.ReadLine();

            switch (property)
            {
                case "face":
                    Console.WriteLine("{0:f2}", FaceDiagonalOfCube(a));
                    break;
                case "space":
                    Console.WriteLine("{0:f2}", SpaceDiagonalOfCube(a));
                    break;
                case "volume":
                    Console.WriteLine("{0:f2}", VolumeOfCube(a));
                    break;
                case "area":
                    Console.WriteLine("{0:f2}", AreaOfCube(a));
                    break;
                default:
                    break;
            }
        }
    }
}