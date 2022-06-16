using System;

namespace HappyCat_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours1 = int.Parse(Console.ReadLine());
            double sum = 0;
            double dailyProfit = 0;
            for (int i = 1; i <= days; i++)
            {
                for (int hours = 1; hours <= hours1; hours++)
                {
                    if (i % 2 == 0 && hours % 2 != 0)
                    {
                        sum += 2.50;
                        dailyProfit += 2.50;
                    }
                    else if (i % 2 != 0 && hours % 2 == 0)
                    {
                        sum += 1.25;
                        dailyProfit += 1.25;
                    }

                    else
                    {
                        sum += 1;
                        dailyProfit += 1;
                    }
                }
                Console.WriteLine($"Day: {i} - {dailyProfit:f2} leva");
                dailyProfit = 0;
            }
            Console.WriteLine($"Total: {sum:f2} leva");
        }
    }
}
