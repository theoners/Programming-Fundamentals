using System;

namespace _04._Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string unit = Console.ReadLine();
            decimal inputUnits = decimal.Parse(Console.ReadLine());
            
            decimal multipleBy = 0m;
            string outputUnit = "";

            switch (unit)
            {
                case "miles":
                    multipleBy = 1.6m;
                    outputUnit = "kilometers";
                    break;
                case "inches":
                    multipleBy = 2.54m;
                    outputUnit = "centimeters";
                    break;
                case "feet":
                    multipleBy = 30;
                    outputUnit = "centimeters";
                    break;
                case "yards":
                    multipleBy = 0.91m;
                    outputUnit = "meters";
                    break;
                case "gallons":
                    multipleBy = 3.8m;
                    outputUnit = "liters";
                    break;
            }
            decimal result = inputUnits * multipleBy;
            Console.WriteLine($"{inputUnits} {unit} = {result:F2} {outputUnit}");
        }
    }
}
