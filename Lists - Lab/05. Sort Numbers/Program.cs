﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            numbers.Sort();

            Console.WriteLine(string.Join(" <= ", numbers));
        }
    }
}
