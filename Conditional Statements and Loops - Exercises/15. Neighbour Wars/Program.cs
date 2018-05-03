using System;

namespace _15._Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());
            int peshoHealt = 100;
            int goshoHealt = 100;
            int round = 0;

            for (int i = 0; i < 100; i++)
            {
                round++;
                if (round % 2 == 1)
                {
                    goshoHealt = goshoHealt - peshoDamage;
                    if (goshoHealt <= 0)
                    {
                        Console.WriteLine($"Pesho won in {round}th round.");
                        return;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealt} health.");
                    if (round % 3 == 0)
                    {
                        goshoHealt = goshoHealt + 10;
                        peshoHealt = peshoHealt + 10;
                    }
                }
                else
                {
                    peshoHealt = peshoHealt - goshoDamage;
                    if (peshoHealt <= 0)
                    {
                        Console.WriteLine($"Gosho won in {round}th round.");
                        return;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealt} health.");
                    if (round % 3 == 0)
                    {
                        goshoHealt = goshoHealt + 10;
                        peshoHealt = peshoHealt + 10;
                    }
                }
            }
        }
    }
}
