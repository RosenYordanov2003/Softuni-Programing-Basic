using System;

namespace Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string country = "";
            string Typelocation = "";
            double priceforholiday = 0;
            if (budget <= 100)
            {
                country = "Bulgaria";
                if (season == "summer")
                {
                    priceforholiday = budget * 30 / 100.0;
                    Typelocation = "Camp";
                    Console.WriteLine($"Somewhere in {country}");
                    Console.WriteLine($"{Typelocation} - {priceforholiday:F2}");
                }
                else if (budget <= 100)
                {
                    country = "Bulgaria";
                    if (season == "winter")
                    {
                        priceforholiday = budget * 70 / 100;
                        Typelocation = "Hotel";
                        Console.WriteLine($"Somewhere in {country}");
                        Console.WriteLine($"{Typelocation} - {priceforholiday:F2}");
                    }
                }

            }
            else if (budget <= 1000)
            {
                country = "Balkans";
                if (season == "summer")
                {
                    Typelocation = "Camp";
                    priceforholiday = budget * 40 / 100;
                    Console.WriteLine($"Somewhere in {country}");
                    Console.WriteLine($"{Typelocation} - {priceforholiday:F2}");

                }
                else if (season == "winter")
                {
                    Typelocation = "Hotel";
                    priceforholiday = budget * 80 / 100;
                    Console.WriteLine($"Somewhere in {country}");
                    Console.WriteLine($"{Typelocation} - {priceforholiday:F2}");
                }
            }
            else if (budget > 1000)
            {
                country = "Europe";
                Typelocation = "Hotel";
                priceforholiday = budget * 90 / 100;
                Console.WriteLine($"Somewhere in {country}");
                Console.WriteLine($"{Typelocation} - {priceforholiday:F2}");
            }
        }
    }
}
