using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var logsReport = new SortedDictionary<string, SortedDictionary<string, int>>();
            string ip = "";
            string name = "";
            int time = 0;
            int sumTime = 0;
            string ipList = ""; 

            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine().Split(' ');
                ip = input[0];
                name = input[1];
                time = int.Parse(input[2]);


                if (!logsReport.ContainsKey(name))
                {
                    logsReport.Add(name, new SortedDictionary<string, int>());
                }
                if (!logsReport[name].ContainsKey(ip))
                {
                    logsReport[name].Add(ip, time);
                }
                else
                {
                    logsReport[name][ip] = logsReport[name][ip] + time;
                }
            }

            foreach (var people in logsReport)
            {
                name = people.Key;
                Console.Write($"{name}: ");
                foreach (var ipandTime in logsReport[name])
                {
                    sumTime = ipandTime.Value + sumTime;
                    
                      ipList = (string.Join(", ",logsReport[name].Keys));
                }
                
                Console.Write($"{sumTime} ");
                Console.WriteLine($"[{ipList}]");
                sumTime = 0;
            }
        }
    }
}
