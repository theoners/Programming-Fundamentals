using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDradons = int.Parse(Console.ReadLine());
            var dragons = new Dictionary<string, SortedDictionary<string, string>>();
            string dragonsStats = "";
            List<double> avarageDamage =new List<double>() ;
            List<double> avaregeHealth = new List<double>();
            List<double> avarageArmor = new List<double>();
            List<string> nameOfdragon = new List<string>();

            for (int i = 0; i < numberOfDradons; i++)
            {
                var input = Console.ReadLine().Split(' ');

                if (!dragons.ContainsKey(input[0]))
                {
                    dragons.Add(input[0], new SortedDictionary<string, string>());
                }
                dragonsStats = input[2]+" "+input[3]+ " " + input[4];
                if (dragons[input[0]].ContainsValue(input[1]))
                {
                    dragons[input[0]].Add(input[1],"");
                }
                dragons[input[0]][input[1]]=dragonsStats;
                dragonsStats = "";
            }
            foreach (var dragonType in dragons)
            {
                foreach (var dragonsAndStats  in dragonType.Value)
                {
                    List<string> stats = dragonsAndStats.Value.Split(' ')
                        .ToList();
                    if (stats[0]!="null")
                    {
                        avarageDamage.Add(int.Parse(stats[0]));
                    }
                    else
                    {
                        avarageDamage.Add(45);
                    }
                    if (stats[1] != "null")
                    {
                        avaregeHealth.Add(int.Parse(stats[1]));
                    }
                    else
                    {
                        avaregeHealth.Add(250);
                    }
                    if (stats[2] != "null")
                    {
                        avarageArmor.Add(int.Parse(stats[2]));
                    }
                    else
                    {
                        avarageArmor.Add(10);
                    }
                    nameOfdragon = dragonType.Value.Keys.ToList();
                }
                Console.WriteLine($"{dragonType.Key}::" +
                    $"({avarageDamage.Average():F2}" +
                    $"/{avaregeHealth.Average():F2}" +
                    $"/{avarageArmor.Average():F2})");
                
                    for (int i = 0; i < avarageArmor.Count; i++)
                    {
                        Console.WriteLine($"-{nameOfdragon[i]} -> " +
                            $"damage: {avarageDamage[i]}, " +
                            $"health: {avaregeHealth[i]}, " +
                            $"armor: {avarageArmor[i]}");
                    }
                avarageArmor.Clear();
                avarageDamage.Clear();
                avaregeHealth.Clear();
            }
        }
    }
}
