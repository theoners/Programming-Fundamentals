using System;
using System.Numerics;

namespace _06._Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            BigInteger id = 0; 
            BigInteger thiefsID = long.MinValue;

            for (int i = 0; i < n; i++)
            {
               id = BigInteger.Parse(Console.ReadLine());

                if (numeralType=="sbyte")
                {
                    if (id<=sbyte.MaxValue && id>=sbyte.MinValue)
                    {
                        
                        if (thiefsID<id)
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
            Console.WriteLine(thiefsID);
        }
    }
}
