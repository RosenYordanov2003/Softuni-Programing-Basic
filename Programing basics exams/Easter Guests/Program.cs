using System;

namespace Easter_Guests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double countGuests = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            int priceKozunak = 4;
            double countEggs = countGuests * 2;
            double priceEgg = 0.45 * countGuests * 2;
            double countKozunag = Math.Ceiling(countGuests / 3);
            double total = priceEgg + countKozunag * 4;
            if (budget >= total)
            {
                double leftMooney = budget - total;
                Console.WriteLine($"Lyubo bought {countKozunag} Easter bread and {countEggs} eggs.");
                Console.WriteLine($"He has {leftMooney:f2} lv. left.");
            }
            else
            {
                double mooneyNeed = Math.Abs(total - budget);
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {mooneyNeed:f2} lv. more.");
            }
        }
    }
}
