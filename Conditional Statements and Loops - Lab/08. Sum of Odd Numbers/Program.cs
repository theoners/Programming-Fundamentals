using System;

namespace _08._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n * 2; i += 2)
            {

                sum = sum + i;
                Console.WriteLine(i);
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
