using System;

namespace _04._Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            long count = 3;

            bool[] primes = new bool[number+1];

            for (long i = 0; i <= number; i++)
            {
                primes[i] = true;
            }
            primes[0] = primes[1] = false;

            for (long i = 2; i <= number; i++)
            {
                if (primes[i])
                {
                    Console.Write(i+" ");
                    for (long j = i*2; j <= number; j=i*count++)
                    {
                        primes[j] = false;
                    }
                    count = 3;
                }
            }
        }
    }
}
