﻿using System;

namespace _05._Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.Write("Health: ");
            Console.WriteLine("|"+new string('|',currentHealth)+new string('.',maxHealth-currentHealth)+'|');
            Console.Write("Energy: ");
            Console.WriteLine("|" + new string('|', currentEnergy) + new string('.', maxEnergy - currentEnergy) + '|');

        }
    }
}
