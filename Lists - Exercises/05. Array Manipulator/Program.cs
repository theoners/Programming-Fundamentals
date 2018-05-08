using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var nextRow = Console.ReadLine().Split(' ').ToList();
            
            bool isHave = false;
            
           var shifted = new List<int>();
           
            var shift = 0;

            while (nextRow[0] != "print")
            {
               
                if (nextRow[0] == "add")
                {
                    list.Insert(int.Parse (nextRow[1]), int.Parse(nextRow[2]));
                }
                else if (nextRow[0]=="remove")
                {
                    list.RemoveAt(int.Parse(nextRow[1]));
                }
                else if (nextRow[0] == "shift")
                {
                    shift = int.Parse(nextRow[1])%list.Count;

                    shifted = list.Skip(shift).ToList();

                    for (int i = 0; i < shift; i++)
                    {
                        shifted.Add(list[i]);
                    }
                    list = shifted;
                }
                else if (nextRow[0] == "contains")
                {
                   isHave= list.Contains(int.Parse (nextRow[1]));
                    if (isHave)
                    {
                       var element= list.IndexOf(int.Parse(nextRow[1]));
                        Console.WriteLine(element);
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if (nextRow[0] == "sumPairs")
                {
                    var steps = list.Count;
                    for (int i = 0; i < steps / 2; i++)
                    {
                        list[i] +=list[i + 1];
                        list.RemoveAt(i + 1);

                    }
                }
                else if (nextRow[0] == "addMany")
                {
                    var index = int.Parse(nextRow[1]);
                    list.InsertRange(index, nextRow.Skip(2).Select(int.Parse));
                }
                 nextRow = Console.ReadLine().Split(' ').ToList();
            }
            
            Console.Write("[" + string.Join(", ",list)+"]");
          
            
        }
    }
}
