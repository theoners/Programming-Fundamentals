using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var userAndIp = new SortedDictionary<string, Dictionary<string,int>>();
            string input = Console.ReadLine();
            

            while (input!="end")
            {
                var line = input.Split(' ').ToList();

                string user = line[2].Remove(0,5);
                string ip = line[0].Remove(0, 3);

                if (!userAndIp.ContainsKey(user))
                {
                   
                    userAndIp.Add(user,  new Dictionary<string, int>());
                }

                if (!userAndIp[user].ContainsKey(ip))
                {
                    userAndIp[user].Add(ip, 1);
                }
                else
                {
                    userAndIp[user][ip]++;
                }


                 input = Console.ReadLine();
            }

            foreach (var user in userAndIp)
            {
                Console.WriteLine($"{user.Key}: ");
                var ipAdress = user.Value;
                var ipArr = ipAdress.Keys.ToArray();
                var countArr = ipAdress.Values.ToArray();

                for (int i = 0; i < ipArr.Length; i++)
                {
                    Console.Write(ipArr[i]+" => "+countArr[i]);
                    if (i==ipArr.Length-1)
                    {
                        Console.WriteLine('.');
                    }
                    else
                    {
                        Console.Write(", ");
                    }
                }
                
                

            }
        }
    }
}
