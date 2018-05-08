using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            string country = "";
            string city = "";
            long population = 0L;

            var countryCityPopulation = new Dictionary<string, Dictionary<string, long>>();
            var countryPopulation = new Dictionary<string, long>();

            while (line!="report")
            {
                var input = line.Split('|');
                country = input[1];
                city = input[0];
                population = long.Parse(input[2]);

                if (!countryCityPopulation.ContainsKey(country))
                {
                    countryCityPopulation.Add(country, new Dictionary<string, long>());
                    countryPopulation.Add(country,0);
                }
                countryPopulation[country] = countryPopulation[country]+ population; 
                countryCityPopulation[country].Add(city, population);

                line = Console.ReadLine();

            }
             
            countryPopulation = countryPopulation.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in countryPopulation)
            {
                country = kvp.Key;
                population = kvp.Value;
                Console.WriteLine($"{country} (total population: {population})");
                foreach (var item in countryCityPopulation[country].OrderByDescending(x=>x.Value))
                {
                    city = item.Key;
                    var cityPopulation = item.Value;
                    Console.WriteLine($"=>{city}: {cityPopulation}");
                }
            }

            
        }
    }
}
