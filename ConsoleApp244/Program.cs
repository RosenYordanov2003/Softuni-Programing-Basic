using System;

namespace Series_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int series = int.Parse(Console.ReadLine());
            double timePerSerie = double.Parse(Console.ReadLine());
            double advert = timePerSerie * 20 / 100;
            double seriesTotal = timePerSerie + advert;
            double total = seriesTotal * series * seasons + seasons * 10;
            Console.WriteLine($"Total time needed to watch the {movie} series is {Math.Floor(total)} minutes.");
        }
    }
}
