using System;

namespace _01._Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintHelloName(name);
        }

        private static void PrintHelloName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
