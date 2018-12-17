using System;
using System.Linq;

namespace _01._Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var minValue = array.Min();
            var maxValue = array.Max();
            var averageValue = array.Average();
            var sum = array.Sum();

            Console.WriteLine($"Min = {minValue}");
            Console.WriteLine($"Max = {maxValue}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {averageValue}");
        }
    }
}
