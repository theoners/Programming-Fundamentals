using System;
using System.Collections.Generic;

namespace _07.__Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            long start = long.Parse(Console.ReadLine());
            long end = long.Parse(Console.ReadLine());
            List<long> primeNumbers = PrimeNumber(start,end);
            Console.WriteLine(string.Join(", ",primeNumbers));

        }

        public static List<long> PrimeNumber(long start, long end)
        {
            bool isPrime = true;
            List<long> primeNumbers = new List<long>();


            for (long i = start; i <= end; i++)
            {
                for (int k = 2; k <= Math.Sqrt(i); k++)
                {
                    if (i%k==0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime&& i>=2)
                {
                    primeNumbers.Add(i);
                }
                isPrime = true;
            }
            return primeNumbers;
           
        }
    }
}
