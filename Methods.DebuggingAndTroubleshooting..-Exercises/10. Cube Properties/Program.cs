using System;

namespace _10._Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            side = Math.Abs(side);
            string parameter = Console.ReadLine();
            parameter = parameter.ToLower();
            switch (parameter)
            {
                case "face":
                    FaceDiagonal(side);
                    break;
                case "space":
                    SpaceDiagonal(side);
                    break;
                case "volume":
                    Volume(side);
                    break;

                default:
                    Area(side);
                    break;
            }
        }

        static void FaceDiagonal(double side)
        {
            double faceDiagonal = Math.Sqrt(2 * Math.Pow(side, 2));
            Console.WriteLine($"{faceDiagonal:f2}");
        }

        static void SpaceDiagonal(double side)
        {
            double spaceDiagonal = Math.Sqrt(3 * Math.Pow(side, 2));
            Console.WriteLine($"{spaceDiagonal:f2}");
        }

        static void Volume(double side)
        {
            double volume = Math.Pow(side, 3);
            Console.WriteLine($"{volume:f2}");
        }

        static void Area(double side)
        {
            double area = 6 * Math.Pow(side, 2);
            Console.WriteLine($"{area:f2}");
        }
    }
}
