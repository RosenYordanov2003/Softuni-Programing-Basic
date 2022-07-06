using System;

namespace Easter_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countGuests = int.Parse(Console.ReadLine());
            double priceKovert = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double cakeSum = (budget * 10) / 100;
            if (countGuests >= 10 && countGuests <= 15)
            {
                priceKovert = priceKovert - (priceKovert * 15) / 100;
                priceKovert = priceKovert * countGuests;
            }
            else if (countGuests >= 15 && countGuests <= 20)
            {
                priceKovert = priceKovert - (priceKovert * 20) / 100;
                priceKovert = priceKovert * countGuests;
            }
            else if (countGuests >= 20)
            {
                priceKovert = priceKovert - (priceKovert * 25) / 100;
                priceKovert = priceKovert * countGuests;
            }
            else if (countGuests < 10)
            {
                priceKovert = priceKovert * countGuests;
            }
            double total = priceKovert + cakeSum;
            if (budget >= total)
            {
                double leftMooney = Math.Abs(total - budget);
                Console.WriteLine($"It is party time! {leftMooney:f2} leva left.");
            }
            else
            {
                double mooneyNeed = Math.Abs(total - budget);
                Console.WriteLine($"No party! {mooneyNeed:f2} leva needed.");
            }
        }
    }
}
