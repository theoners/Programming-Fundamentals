using System;

namespace _03._Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            long[] seq = new long[n];
            seq[0] = 1;

            for (long i = 1; i < seq.Length; i++)
            {
                for (long j = i - k; j <= i - 1; j++)
                {
                    if (j>=0)
                    {
                        seq[i] = seq[i] + seq[j];
                    }
                    
                }
            }
            foreach (var item in seq)
            {
                Console.Write(item);
                Console.Write(" ");
            }


        }
    }
}
