using System;

namespace _03._Printing_Triangle
{
   class Program
   {
       static void Main(string[] args)
       {
           int number = int.Parse(Console.ReadLine());
           UpSideOfTriangle(number);
           DownSideOfTriangle(number);

       }

       static void UpSideOfTriangle(int number)
       {
           for (int row = 1; row <= number; row++)
           {
               LineOfTriangle(row);
           }
       }

       static void DownSideOfTriangle(int number)
       {
           for (int row = number - 1; row >= 1; row--)
           {
               LineOfTriangle(row);
           }
       }
       static void LineOfTriangle(int row)
       {
           for (int col = 1; col <= row; col++)
           {
               Console.Write(col + " ");
           }
           Console.WriteLine("");
       }
   }

}
