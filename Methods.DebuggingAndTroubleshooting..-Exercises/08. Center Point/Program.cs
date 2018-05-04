using System;

namespace _08._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double firstDiagonal = CalculateDiagonal(x1, y1);
            double secondDiagonal = CalculateDiagonal(x2, y2);
            if (firstDiagonal <= secondDiagonal)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
        static double CalculateDiagonal(double x, double y)
        {
            double diagonal = x * x + y * y;
            return Math.Sqrt(diagonal);
        }
    }
}
