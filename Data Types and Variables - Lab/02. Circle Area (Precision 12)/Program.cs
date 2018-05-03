using System;

namespace _02._Circle_Area__Precision_12_
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double circleArea = Math.PI * radius * radius;
            Console.WriteLine($"{circleArea:f12}");
        }
    }
}
