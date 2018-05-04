using System;
using System.Numerics;

namespace _14._Factorial_Trailing_Zeroes
{
    class Program
    {
            static void Main(string[] args)
            {
                BigInteger n = BigInteger.Parse(Console.ReadLine());
                BigInteger result = CalculateFactorial(n);
                int count = 0;
                int maxCount = 0;

                while (result != 0)
                {
                    BigInteger lastDigit = result % 10;
                    BigInteger newResult = result / 10;
                    result = newResult;
                    if (lastDigit == 0)
                    {
                        count = count + 1;
                    }
                    if (maxCount <= count)
                    {
                        maxCount = count;
                    }
                    if (lastDigit != 0)
                    {
                        count = 0;
                    }
                }
                Console.WriteLine(maxCount);
            }

            static BigInteger CalculateFactorial(BigInteger n)
            {
                BigInteger result = 1;
                for (BigInteger i = 1; i <= n; i++)
                {
                    result = result * i;
                }
                return result;
            }
    }
}
