using System;

namespace _19._Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numberOfPictures = decimal.Parse(Console.ReadLine());
            long filterTimeForPicture = long.Parse(Console.ReadLine());
            decimal goodPictures = decimal.Parse(Console.ReadLine())/100;
            decimal uploadTimeForPicture = decimal.Parse(Console.ReadLine());

            decimal totalPicture = Math.Ceiling(numberOfPictures * goodPictures);
            decimal totalFilterTIme = numberOfPictures * filterTimeForPicture;
            decimal totalUploadTime = totalPicture * uploadTimeForPicture;
            long totalTime =(long) (totalFilterTIme + totalUploadTime);

            long days = totalTime / 86400;
            totalTime -= days * 86400;
            long hours = totalTime / 3600;
            totalTime -= hours * 3600;
            long minutes = totalTime / 60;
            totalTime -= minutes * 60; 
            long seconds = totalTime;
            
           

            Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{seconds:D2}");

        }
    }
}
