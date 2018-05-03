using System;

namespace _08._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double legth, heigth, width = 0;
            Console.Write("Length: ");
            legth = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            heigth = double.Parse(Console.ReadLine());
            double volume = ((legth * width) / 3) * heigth;

            Console.WriteLine("Pyramid Volume: {0:F2}", volume);
        }
    }
}
