using System;

namespace Movie_Destination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string location = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double sum = 0;
            if (location == "Dubai")
            {

                if (season == "Winter")
                {
                    sum = 45000 * days;
                }
                else if (season == "Summer")
                {
                    sum = 40000 * days;
                }
                sum = sum - (sum * 30) / 100;
            }
            else if (location == "Sofia")
            {

                if (season == "Winter")
                {
                    sum = 17000 * days;
                }
                else if (season == "Summer")
                {
                    sum = 12500 * days;
                }
                sum += (sum * 25) / 100;

            }
            else if (location == "London")
            {
                if (season == "Winter")
                {
                    sum = 24000 * days;
                }
                else if (season == "Summer")
                {
                    sum = 20250 * days;
                }
            }


            if (budget >= sum)
            {
                double budgetLeft = budget - sum;
                Console.WriteLine($"The budget for the movie is enough! We have {budgetLeft:f2} leva left!");
            }
            else
            {
                double moneyNeed = Math.Abs(budget - sum);
                Console.WriteLine($"The director needs {moneyNeed:f2} leva more!");
            }
        }
    }
}
