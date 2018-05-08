using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().ToLower().Split(' ');
            
            var materialQuantity = new Dictionary<string, int>();
            materialQuantity.Add("motes", 0);
            materialQuantity.Add("shards", 0);
            materialQuantity.Add("fragments", 0);
           
            var junk = new SortedDictionary<string, int>();
           
            
           // •	Shadowmourne – requires 250 Shards;
           // •	Valanyr – requires 250 Fragments;
           // •	Dragonwrath – requires 250 Motes;


            while (true)
            {
                for (int i = 0 ; i < line.Length-1; i+=2)
                {
                    var material = line[i+1];
                    int quantity = int.Parse(line[i]);

                    if (material == "motes" || material == "shards" || material == "fragments")
                    {
                        
                        materialQuantity[material] += quantity;

                        if (materialQuantity[material]>=250)
                        {
                            if (material=="fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                                
                            }
                            else if (material == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            materialQuantity[material] -= 250;

                            materialQuantity = materialQuantity
                                .OrderByDescending(count => count.Value)
                                .ThenBy(x=>x.Key)
                                .ToDictionary(x => x.Key, y => y.Value);

                            foreach (var item in materialQuantity)
                            {
                                Console.WriteLine(item.Key + ": " + item.Value);
                            }

                            foreach (var item in junk)
                            {
                                Console.WriteLine(item.Key + ": " + item.Value);
                            }
                            return;


                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, 0);
                        }
                        junk[material] += quantity;
                    }
                }
                line = Console.ReadLine().ToLower().Split(' ');
            }
        }
    }
}
