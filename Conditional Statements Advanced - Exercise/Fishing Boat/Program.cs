using System;

namespace Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countfishermans = int.Parse(Console.ReadLine());
            double price = 0;

            if (season == "Spring")
            {
                price += 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                price += 4200;
            }
            else if (season == "Winter")
            {
                price += 2600;
            }
            if (countfishermans <= 6)
            {
                price = price - (price * 10) / 100;
            }
            else if (countfishermans > 7 && countfishermans <= 11)
            {
                price = price - (price * 15) / 100;
            }
            else if (countfishermans > 12)
            {
                price = price - (price * 25) / 100;
            }
            if (countfishermans % 2 == 0 && season != "Autumn")
            {
                price = price - (price * 5) / 100;
            }
            if (price > money)
            {
                double moneyneed = Math.Abs(price - money);
                Console.WriteLine($"Not enough money! You need {moneyneed:F2} leva.");
            }
            else
            {
                double leftmoney = money - price;
                Console.WriteLine($"Yes! You have {leftmoney:F2} leva left.");
            }

        }
    }
}
