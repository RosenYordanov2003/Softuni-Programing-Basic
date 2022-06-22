using System;

namespace Truck_Driver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double km = double.Parse(Console.ReadLine());
            double sum = 0;
            if (km <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    sum = 0.75 * km * 4;
                }
                else if (season == "Summer")
                {
                    sum = 0.90 * km * 4;
                }
                else if (season == "Winter")
                {
                    sum = 1.05 * km * 4;
                }
            }
            else if (km > 5000 && km <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    sum = 0.95 * km * 4;
                }
                else if (season == "Summer")
                {
                    sum = 1.10 * km * 4;
                }
                else if (season == "Winter")
                {
                    sum = 1.25 * km * 4;
                }
            }
            else if (km > 10000 && km <= 20000)
            {
                sum = 1.45 * km * 4;
            }
            sum = sum - (sum * 10) / 100;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
