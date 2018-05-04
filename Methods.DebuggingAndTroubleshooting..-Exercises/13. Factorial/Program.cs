using System;
using System.Numerics;

namespace _13._Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            CalculateFactorial(n);
        }

        private static void CalculateFactorial(BigInteger n)
        {
            BigInteger result = 1;
            for (BigInteger i = 1; i <= n; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }
    }
}
