using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var resource = Console.ReadLine();
           

            var resourcesAndQuantity = new Dictionary<string, decimal>();

            while (resource!="stop")
            {
                  var quantity = decimal.Parse(Console.ReadLine());
                if (!resourcesAndQuantity.ContainsKey(resource))
                {
                    resourcesAndQuantity[resource] = quantity;
                }
                else
                {
                    resourcesAndQuantity[resource] += quantity;
                }
                 resource = Console.ReadLine();
                

            }
            foreach (var resAndQuantity in resourcesAndQuantity)
            {
                resource = resAndQuantity.Key;
               var  quantity = resAndQuantity.Value;

                Console.WriteLine(resource + " -> " + quantity);
            }
        }
    }
}
