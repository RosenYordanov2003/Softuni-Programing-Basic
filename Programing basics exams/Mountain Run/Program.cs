using System;

namespace Mountain_Run
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeteers = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());
            double totalSec = distanceInMeteers * timeInSeconds;
            double latesec = Math.Floor(distanceInMeteers / 50) * 30;
            double total = totalSec + latesec;
            if (total < recordInSeconds)
            {
                Console.WriteLine($" Yes! The new record is {total:f2} seconds.");
            }
            else
            {
                double diff = Math.Abs(recordInSeconds - total);
                Console.WriteLine($"No! He was {diff:f2} seconds slower.");
            }
        }
    }
}
