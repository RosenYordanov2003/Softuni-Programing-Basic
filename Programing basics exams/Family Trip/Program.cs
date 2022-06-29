using System;

namespace Family_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countNights = int.Parse(Console.ReadLine());
            double priceNight = double.Parse(Console.ReadLine());
            double Percent = int.Parse(Console.ReadLine());
            if (countNights > 7)
            {
                priceNight = priceNight - (priceNight * 5) / 100;
            }
            double totalNights = countNights * priceNight;
            Percent = budget * Percent / 100;
            double total = totalNights + Percent;
            if (budget >= total)
            {
                Console.WriteLine($"Ivanovi will be left with {budget - total:f2} leva after vacation.");
            }
            else
            {
                double mooneyNeed = Math.Abs(budget - total);
                Console.WriteLine($"{mooneyNeed:f2} leva needed.");
            }
        }
    }
}
