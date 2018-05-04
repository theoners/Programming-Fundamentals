using System;

namespace _02._Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int bigNumber = GetMax(a, b, c);
            Console.WriteLine(bigNumber);
        }

        static int GetMax(int a, int b, int c)
        {
            int firstBigNumber = Math.Max(a, b);
            int bigNumber = Math.Max(c, firstBigNumber);
            return bigNumber;
        }
    }
}
