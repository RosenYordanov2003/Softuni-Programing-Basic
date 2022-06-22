using System;

namespace Bike_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int count = juniors + seniors;
            double sum = 0;
            if (type == "trail")
            {
                sum += 5.50 * juniors;
                sum += 7 * seniors;
            }
            else if (type == "cross-country")
            {
                sum += 8 * juniors;
                sum += 9.50 * seniors;
                if (count >= 50)
                {
                    sum = sum - (sum * 25) / 100;
                }
            }
            else if (type == "downhill")
            {
                sum += 12.25 * juniors;
                sum += 13.75 * seniors;
            }
            else if (type == "road")
            {
                sum += 20 * juniors;
                sum += 21.50 * seniors;
            }
            sum = sum - (sum * 5) / 100;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
