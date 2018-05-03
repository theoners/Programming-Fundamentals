using System;

namespace _03._Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            int pricePlace = 0;
            double procentDiscount = 0;
            int pricePackage = 0;
            string hall = "";

            if (groupSize < 51)
            {
                pricePlace = 2500;
                hall = "Small Hall";
            }
            else if (groupSize < 101)
            {
                pricePlace = 5000;
                hall = "Terrace";
            }
            else if (groupSize < 120)
            {
                pricePlace = 7500;
                hall = "Great Hall";
            }
            if (package.Equals("Normal"))
            {
                pricePackage = 500;
                procentDiscount = 0.05;
            }
            else if (package.Equals("Gold"))
            {
                pricePackage = 750;
                procentDiscount = 0.10;
            }
            else if (package.Equals("Platinum"))
            {
                pricePackage = 1000;
                procentDiscount = 0.15;
            }
            if (pricePlace == 0)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                double totalPrice = (pricePlace + pricePackage);
                double totalPriceWithDiscount = totalPrice - (totalPrice * procentDiscount);
                double priceForPerson = totalPriceWithDiscount / groupSize;
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {priceForPerson:f2}$");
            }
    }
}
