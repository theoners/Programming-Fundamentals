using System;

namespace _12._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string name = "";
            double maxVolume = double.MinValue;

            for (int i = 0; i < n; i++)
            {
                string currenName = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double volume = Math.PI * radius * radius * height;

                if (volume>maxVolume)
                {
                    maxVolume = volume;
                    name = currenName;
                }

            }
            Console.WriteLine(name);
        }
    }
}
