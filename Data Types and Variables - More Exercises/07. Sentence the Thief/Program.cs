using System;
using System.Numerics;

namespace _07._Sentence_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            BigInteger thiefsID = long.MinValue;
            BigInteger durationOfTheSentence = 0;

            for (int i = 0; i < n; i++)
            {
                BigInteger id = BigInteger.Parse(Console.ReadLine());
                if (numeralType == "sbyte")
                {
                    if (id <= sbyte.MaxValue && id >= sbyte.MinValue)
                    {

                        if (thiefsID < id)
                        {
                            thiefsID = id;
                        }
                    }
                }
                else if (numeralType == "int")
                {
                    if (id <= int.MaxValue && id >= int.MinValue)
                    {

                        if (thiefsID < id)
                        {
                            thiefsID = id;
                        }
                    }
                }
                else if (numeralType == "long")
                {
                    if (id <= long.MaxValue && id >= long.MinValue)
                    {

                        if (thiefsID < id)
                        {
                            thiefsID = id;
                        }
                    }
                }
            }
            if (thiefsID<0)
            {
                durationOfTheSentence = thiefsID / -128;
            }
            else
            {
                durationOfTheSentence = thiefsID /127;
            }

            if (durationOfTheSentence==0)
            {
                Console.WriteLine($"Prisoner with id {thiefsID} is sentenced to {durationOfTheSentence+1} year");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {thiefsID} is sentenced to {durationOfTheSentence+1} years");
            }
        }
    }
}
