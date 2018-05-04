using System;

namespace _11._Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            switch (figure)
            {
                case "triangle":
                    double sideTriangle = double.Parse(Console.ReadLine());
                    double heightTriangle = double.Parse(Console.ReadLine());
                    TriangleArea(sideTriangle, heightTriangle);
                    break;
                case "square":
                    double sideSquare = double.Parse(Console.ReadLine());
                    SquareArea(sideSquare);
                    break;
                case "rectangle":
                    double widthRectangle = double.Parse(Console.ReadLine());
                    double heightRectangle = double.Parse(Console.ReadLine());
                    RectangleArea(widthRectangle, heightRectangle);
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    CircleArea(radius);
                    break;
                default:
                    break;
            }
        }

        static void CircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"{area:f2}");
        }

        static void RectangleArea(double widthRectangle, double heightRectangle)
        {
            double area = widthRectangle * heightRectangle;
            Console.WriteLine($"{area:f2}");
        }

        static void SquareArea(double sideSquare)
        {
            double area = sideSquare * sideSquare;
            Console.WriteLine($"{area:f2}");

        }

        static void TriangleArea(double side, double height)
        {
            double area = (side * height) / 2;
            Console.WriteLine($"{area:f2}");
        }
    }
}
