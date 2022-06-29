using System;

namespace Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countSerials = int.Parse(Console.ReadLine());
            double totalSum = 0;
            for (int i = 1; i <= countSerials; i++)
            {
                string serialName = Console.ReadLine();
                double serialPrice = double.Parse(Console.ReadLine());

                if (serialName == "Thrones")
                {
                    serialPrice = serialPrice - (serialPrice * 50) / 100;
                }
                else if (serialName == "Lucifer")
                {
                    serialPrice = serialPrice - (serialPrice * 40) / 100;
                }
                else if (serialName == "Protector")
                {
                    serialPrice = serialPrice - (serialPrice * 30) / 100;
                }
                else if (serialName == "TotalDrama")
                {

                    serialPrice = serialPrice - (serialPrice * 20) / 100;
                }
                else if (serialName == "Area")
                {
                    serialPrice = serialPrice - (serialPrice * 10) / 100;
                }
                totalSum += serialPrice;
            }
            if (budget >= totalSum)
            {
                double leftMooney = budget - totalSum;
                Console.WriteLine($"You bought all the series and left with {leftMooney:f2} lv.");
            }
            else
            {
                double mooneyNeed = Math.Abs(budget - totalSum);
                Console.WriteLine($"You need {mooneyNeed:f2} lv. more to buy the series!");
            }
        }
    }
}
