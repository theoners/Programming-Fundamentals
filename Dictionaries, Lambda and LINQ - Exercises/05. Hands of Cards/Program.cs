using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> powers = GetPowers();
            Dictionary<string, int> typeCards = GetTypeCards();
            var players =new Dictionary<string, List<string>>();

            var input = Console.ReadLine();

            while (input != "JOKER")
            {
                var line = input
                .Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                var playersName = line[0];
                var cards = line[1]
                    .Split(new[] { ", " },StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (!players.ContainsKey(playersName))
                {
                    players.Add(playersName, new List<string>());
                }

                players[playersName].AddRange(cards);

                 input = Console.ReadLine();

            }
            foreach (var player in players)
            {
                var name = player.Key;
                string[] playerCards = player.Value.Distinct().ToArray();

                int cardSum = GetCardsSum(playerCards, powers, typeCards);
                Console.WriteLine($"{name}: {cardSum}");
            }
        }

        private static int GetCardsSum(string[] playerCards, Dictionary<string, int> powers, Dictionary<string, int> typeCards)
        {
            int sum = 0;
            foreach (var card in playerCards)
            {
                string type = card[card.Length - 1].ToString();
                var power = card[0].ToString();

                sum += typeCards[type] * powers[power];
            }
            

            return sum;
        }

        private static Dictionary<string, int> GetPowers()
        {
            var powers = new Dictionary<string, int>();

            for (int i = 2; i < 11; i++)
            {
                powers.Add(i.ToString(), i);
            }
            powers["1"] = 10;
            powers["J"] = 11;
            powers["Q"] = 12;
            powers["K"] = 13;
            powers["A"] = 14;


            return powers;
        }

        private static Dictionary<string,int> GetTypeCards()
        {
            var type = new Dictionary<string, int>();
            type["S"]= 4;
            type["H"]= 3;
            type["D"]= 2;
            type["C"] = 1;
            return type;
        }
    }
}
