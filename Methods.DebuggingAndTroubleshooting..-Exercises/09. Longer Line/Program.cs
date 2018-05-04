using System;

namespace _09._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            double firstDiagonal = CalculateDiagonal(x1, y1);
            double secondDiagonal = CalculateDiagonal(x2, y2);
            double thirdDiagonal = CalculateDiagonal(x3, y3);
            double fourthDiagonal = CalculateDiagonal(x4, y4);

            double diagonalBetweenFirstPionts = CalculateDiagonal(x2 - x1, y2 - y1);
            double diagonalBetweenSecondPoints = CalculateDiagonal(x4 - x3, y4 - y3);
            if (diagonalBetweenFirstPionts >= diagonalBetweenSecondPoints)
            {
                if (firstDiagonal <= secondDiagonal)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (thirdDiagonal <= fourthDiagonal)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }
        static double CalculateDiagonal(double x, double y)
        {
            double diagonal = x * x + y * y;
            return Math.Sqrt(diagonal);
        }
    }
}
