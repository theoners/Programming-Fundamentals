using System;

namespace _04._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleNumber = int.Parse(Console.ReadLine());
            int capacityNumber = int.Parse(Console.ReadLine());

            int cours = peopleNumber / capacityNumber;
            int plusCours = peopleNumber % capacityNumber;
            if (plusCours == 0)
            {
                Console.WriteLine($"{cours}");
            }
            else
            {
                Console.WriteLine($"{cours + 1}");
            }
        }
    }
}
