using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var bombList  = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var bombNumber = bombList[0];
            var power = bombList[1];

            while (numbers.Contains(bombNumber))
            {
                var indexBomb = numbers.IndexOf(bombNumber);

                

                if (indexBomb+power<=numbers.Count)
                {
                    for (int i = indexBomb; i <= indexBomb + power; i++)
                    {
                        numbers.RemoveAt(indexBomb);
                    }
                }
                else
                {
                    var cycle = numbers.Count;
                    for (int i = indexBomb; i < cycle; i++)
                    {
                        numbers.RemoveAt(indexBomb);
                    }
                }
                if ((indexBomb-power)>=0)
                {
                    for (int i = indexBomb-power; i < indexBomb; i++)
                    {
                        numbers.RemoveAt(indexBomb-power);
                    }
                }
                else
                {
                    numbers = numbers.Skip(indexBomb).ToList();
                }

               
            }
            var sum = numbers.Sum();

            Console.WriteLine(sum);
            


        }
    }
}
