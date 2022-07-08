using System;

namespace Cat_Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int caloriesPerMinute = 5;
            int minutesPerDayGoOut = int.Parse(Console.ReadLine());
            int countGoOut = int.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());
            int totalBurnCalories = caloriesPerMinute * minutesPerDayGoOut * countGoOut;
            if (totalBurnCalories >= calories / 2)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalBurnCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalBurnCalories}.");
            }
        }
    }
}
