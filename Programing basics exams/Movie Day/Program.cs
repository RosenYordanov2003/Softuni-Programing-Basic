using System;

namespace Movie_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timeToPhotos = int.Parse(Console.ReadLine());
            int scens = int.Parse(Console.ReadLine());
            int scensTime = int.Parse(Console.ReadLine());
            int prepair = (timeToPhotos * 15) / 100;
            int total = prepair + (scens * scensTime);
            if (timeToPhotos >= total)
            {
                int leftTime = (timeToPhotos - total);
                Console.WriteLine($"You managed to finish the movie on time! You have {leftTime} minutes left!");
            }
            else
            {
                int timeNeed = Math.Abs(timeToPhotos - total);
                Console.WriteLine($"Time is up! To complete the movie you need {timeNeed} minutes.");
            }
        }
    }
}
