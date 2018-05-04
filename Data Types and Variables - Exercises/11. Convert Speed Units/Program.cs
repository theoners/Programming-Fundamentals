using System;

namespace _11._Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal distance = int.Parse(Console.ReadLine());
            decimal hours  = int.Parse(Console.ReadLine());
            decimal minutes  = int.Parse(Console.ReadLine());
            decimal seconds  = int.Parse(Console.ReadLine());

            decimal totalSeconds = hours * 3600 + minutes * 60 + seconds;
            decimal TotalHours = hours + minutes / 60 + seconds / 3600;
            decimal miles = distance/1609;
            decimal distanceInKm = distance / 1000;
            

            Console.WriteLine($"{(distance/totalSeconds):F6}");
            Console.WriteLine($"{(distanceInKm / TotalHours):F6}");
            Console.WriteLine($"{(miles / TotalHours):F6}");
        }
    }
}
