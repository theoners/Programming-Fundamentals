using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var concert = new Dictionary<string, Dictionary<string, int>>();
            int venueIndex = 0;
            string venueName = "";
            string artistName = "";
            int ticketPrice = 0;
            int ticketCount = 0;
            var ticketPriceValid = false;
            var ticketCountValid = false;
            var totalMoney = 0;
            

            while (line!="End")
            {
                var input = line.Split(' ');

                if (input.Length>=4)
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i].StartsWith("@"))
                        {
                            venueIndex = i;
                            for (int k = i; k < input.Length-2; k++)
                            {
                                venueName = venueName + input[k] + " ";
                                venueName = venueName.TrimStart('@');
                            }
                        }
                    }
                    if (venueIndex!=0)
                    {
                        for (int i = 0; i < venueIndex; i++)
                        {
                            artistName =artistName + input[i]+" ";
                        }
                        if (artistName != "")
                        {
                            ticketPriceValid = int.TryParse(input[input.Length - 1], out int result);
                            ticketCountValid = int.TryParse(input[input.Length - 2], out int result1);
                            if (ticketPriceValid && ticketCountValid)
                            {
                                ticketPrice = int.Parse(input[input.Length - 1]);
                                ticketCount = int.Parse(input[input.Length - 2]);
                                totalMoney = ticketCount * ticketPrice;

                                if (!concert.ContainsKey(venueName))
                                {
                                    concert.Add(venueName, new Dictionary<string, int>());
                                }
                                if (!concert[venueName].ContainsKey(artistName))
                                {
                                    concert[venueName].Add(artistName, 0);
                                }

                                concert[venueName][artistName] = concert[venueName][artistName] + totalMoney;
                                
                            }
                        }
                    }
                    
                }
                venueIndex = 0;
                venueName = "";
                artistName = "";
                ticketPrice = 0;
                ticketCount = 0;
                ticketPriceValid = false;
                ticketCountValid = false;
                totalMoney = 0;
                line = Console.ReadLine();
            }
            
            foreach (var venue  in concert)
            {
                Console.WriteLine(venue.Key);
                foreach (var nameMoney in venue.Value.OrderByDescending(x=>x.Value))
                {
                    artistName = nameMoney.Key;
                    totalMoney = nameMoney.Value;
                    Console.WriteLine($"#  {artistName}-> {totalMoney}");
                }
            }
        }
    }
}
