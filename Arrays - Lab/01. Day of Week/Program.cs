using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNumber = int.Parse(Console.ReadLine());
            string[] dayOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };
            if (dayNumber<=7 && dayNumber>=1)
            {
                Console.WriteLine(dayOfWeek[dayNumber - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
            
        }
    }
}
