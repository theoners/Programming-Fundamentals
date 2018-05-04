using System;
using System.Numerics;

namespace _18._Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            if (number <= long.MaxValue && number >= long.MinValue)
            {
                Console.WriteLine($"{number} can fit in: "); 
            }
            else
            {
                Console.WriteLine(number+ " can't fit in any type");
            }

            if (number<=sbyte.MaxValue && number>=sbyte.MinValue)
            {
                Console.WriteLine("* sbyte");
            }
            if (number <= byte.MaxValue && number >= byte.MinValue)
            {
                Console.WriteLine("* byte");
            }
            if (number <= short.MaxValue && number >= short.MinValue)
            {
                Console.WriteLine("* short");
            }
            if (number <= ushort.MaxValue && number >= ushort.MinValue)
            {
                Console.WriteLine("* ushort");
            }
            if (number <= int.MaxValue && number >= int.MinValue)
            {
                Console.WriteLine("* int");
            }
            if (number <= uint.MaxValue && number >= uint.MinValue)
            {
                Console.WriteLine("* uint");
            }
            if (number <= long.MaxValue && number >= long.MinValue)
            {
                Console.WriteLine("* long");
            }
        }
    }
}
