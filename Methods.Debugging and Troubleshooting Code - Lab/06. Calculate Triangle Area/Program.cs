using System;

namespace _06._Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double side = double.Parse(Console.ReadLine());
            double area = TriangleArea(height, side);
            Console.WriteLine(area);
        }

        static double TriangleArea(double height, double side)
        {
            return height * side / 2;
        }
    }
}

