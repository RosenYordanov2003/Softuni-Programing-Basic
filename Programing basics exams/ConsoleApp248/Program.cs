using System;

namespace ConsoleApp248
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guidePrice = 100;
            double budget = double.Parse(Console.ReadLine());
            double gas = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            double total = guidePrice + gas * 2.10;
            if (day == "Saturday")
            {
                total = total - (total * 10) / 100;
            }
            else if (day == "Sunday")
            {
                total = total - (total * 20) / 100;
            }
            if (budget >= total)
            {
                double leftMooney = budget - total;
                Console.WriteLine($"Safari time! Money left: {leftMooney:f2} lv. ");
            }
            else
            {
                double mooneyNeed = Math.Abs(budget - total);
                Console.WriteLine($"Not enough money! Money needed: {mooneyNeed:f2} lv.");
            }
        }
    }
}
