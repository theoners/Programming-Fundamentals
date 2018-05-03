using System;

namespace _04._Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());
            int priceStudio = 0;
            int priceDouble = 0;
            int priceSuite = 0;

            if (month.Equals("May") || month.Equals("October"))
            {
                priceStudio = 50;
                priceDouble = 65;
                priceSuite = 75;
            }
            else if (month.Equals("June") || month.Equals("September"))
            {
                priceStudio = 60;
                priceDouble = 72;
                priceSuite = 82;
            }
            else if (month.Equals("July") || month.Equals("December") || month.Equals("August"))
            {
                priceStudio = 68;
                priceDouble = 77;
                priceSuite = 89;
            }

            double totalPriceStudio = priceStudio * nightCount;
            double totalPriceDouble = priceDouble * nightCount;
            double totalPriceSuite = priceSuite * nightCount;

            if (nightCount > 7 && month.Equals("May"))
            {
                totalPriceStudio = totalPriceStudio * 0.95;
            }
            else if (nightCount > 7 && month.Equals("October"))
            {
                totalPriceStudio = (totalPriceStudio - 50) * 0.95;
            }
            else if (nightCount > 14 && (month.Equals("July") || month.Equals("December") || month.Equals("August")))
            {
                totalPriceSuite = totalPriceSuite * 0.85;
            }
            else if (nightCount > 14 && (month.Equals("June") || month.Equals("September")))
            {
                totalPriceDouble = totalPriceDouble * 0.90;
            }
            else if (nightCount > 7 && month.Equals("September"))
            {
                totalPriceStudio = totalPriceStudio - 60;
            }
            Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
            Console.WriteLine($"Double: {totalPriceDouble:f2} lv.");
            Console.WriteLine($"Suite: {totalPriceSuite:f2} lv.");
        }
    }
}
