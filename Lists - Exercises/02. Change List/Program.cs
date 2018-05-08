using System;
using System.Collections.Generic;
using System.Linq;


namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNumber = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var nextRow = Console.ReadLine().Split(' ').ToList();
            var index = 0;
            var number = 0;
            

            while (!(nextRow[0].Equals("Odd") || nextRow[0].Equals("Even")))
            {
                if (nextRow[0].Equals("Delete"))
                {
                    number = int.Parse(nextRow[1]);

                    listOfNumber.RemoveAll(item => item == number);
                }
                if (nextRow[0].Equals("Insert"))
                {
                    index = int.Parse(nextRow[2]);
                    number = int.Parse(nextRow[1]);
                    listOfNumber.Insert(index,number);
                }
                nextRow = Console.ReadLine().Split(' ').ToList();
            }

            if (nextRow[0].Equals("Odd"))
            {
                foreach (var numbers in listOfNumber)
                {
                    if (numbers%2==1)
                    {
                        Console.Write(numbers);
                        Console.Write(" ");
                        
                    }
                }
            }
            else
            {
                foreach(var numbers in listOfNumber)
                {
                    if (numbers % 2 == 0)
                    {
                        Console.Write(numbers);
                        Console.Write(" ");
                        
                    }
                }
            }
            Console.WriteLine();


        }
    }
}
