using System;

namespace _03._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tankCapacity = 255;
            int waterInTank = 0;

            for (int i = 0; i < n; i++)
            {
                int water = int.Parse(Console.ReadLine());

                if (waterInTank+water<=255)
                {
                    waterInTank += water;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(waterInTank);
        }
    }
}
