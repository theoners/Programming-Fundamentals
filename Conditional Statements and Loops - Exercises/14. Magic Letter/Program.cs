using System;

namespace _14._Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char lastLetter = char.Parse(Console.ReadLine());
            char restractedLetter = char.Parse(Console.ReadLine());

            for (int i = firstLetter; i <= lastLetter; i++)
            {
                for (int j = firstLetter; j <= lastLetter; j++)
                {
                    for (int k = firstLetter; k <= lastLetter; k++)
                    {
                        if (!i.Equals(restractedLetter) && !j.Equals(restractedLetter) && !k.Equals(restractedLetter))
                        {
                            Console.Write($"{(char)i}{(char)j}{(char)k} ");
                        }
                    }
                }
            }
        }
    }
}
