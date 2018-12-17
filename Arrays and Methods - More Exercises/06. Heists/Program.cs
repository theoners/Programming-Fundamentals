using System;

namespace _06._Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var jewelPrice = int.Parse(
                input[0]);
            var goldPrice = int.Parse(input[1]);
            var totalIncome = 0;

            while (true)
            {
                var line = Console.ReadLine();

                if (line=="Jail Time")
                {
                    break;
                }

                var symbols = line.Split()[0];
                var expense = int.Parse(line.Split()[1]);

                for (int i = 0; i < symbols.Length; i++)
                {
                    if (symbols[i]=='%')
                    {
                        totalIncome += jewelPrice;
                    }
                    else if(symbols[i]=='$')
                    {
                        totalIncome += goldPrice;
                    }
                }

                totalIncome -= expense;
            }

            if (totalIncome>=0)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalIncome}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(totalIncome)}.");
            }
        }
    }
}
