using System;

namespace Conditional_Statements_Advanced___More_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            double countPeople = int.Parse(Console.ReadLine());
            if (countPeople >= 5 && countPeople <= 9)
            {
                budget = budget - (budget * 60) / 100;

            }
            else if (countPeople >= 1 && countPeople <= 4)
            {
                budget = budget - (budget * 75) / 100;

            }
            else if (countPeople >= 10 && countPeople <= 24)
            {
                budget = budget - (budget * 50) / 100;
            }
            else if (countPeople >= 25 && countPeople <= 49)
            {
                budget = budget - (budget * 40) / 100;
            }
            else
            {
                budget = budget - (budget * 25) / 100;
            }
            if (type == "VIP")
            {
                budget -= 499.99 * countPeople;
            }
            else if (type == "Normal")
            {
                budget -= 249.99 * countPeople;
            }

            if (budget >= 0)
            {

                Console.WriteLine($"Yes! You have {budget:f2} leva left.");
            }
            else
            {
                budget = Math.Abs(budget);
                Console.WriteLine($"Not enough money! You need {budget:f2} leva.");
            }
        }
    }
}
