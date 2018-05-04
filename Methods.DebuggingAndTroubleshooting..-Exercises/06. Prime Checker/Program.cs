using System;

namespace _6._Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }

        public static bool IsPrime(long n)
        {
            bool isPrime = true;
            if (n < 2)
            {
                isPrime = false;
                return isPrime;
            }

            for (long i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0 || n <= 1)
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }

    }
}
