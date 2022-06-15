using System;

namespace Report_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moneyNeeded = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int cashCounter = 0;
            int creditCardCounter = 0;
            int counter = 0;
            double totalSum = 0;
            double sumbyCard = 0;
            double sumbyCash = 0;
            while (input != "End")
            {
                int pricemoney = int.Parse(input);
                if (counter % 2 == 0)
                {
                    if (pricemoney > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        sumbyCash += pricemoney;
                        cashCounter++;
                    }
                }
                else
                {
                    if (pricemoney < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        sumbyCard += pricemoney;
                        creditCardCounter++;
                    }
                }
                totalSum = sumbyCard + sumbyCash;
                if (totalSum >= moneyNeeded)
                {
                    Console.WriteLine($"Average CS: {sumbyCash / cashCounter:f2}");
                    Console.WriteLine($"Average CC: {sumbyCard / creditCardCounter:f2}");
                    break;
                }
                input = Console.ReadLine();
                if (input == "End")
                {
                    Console.WriteLine("Failed to collect required money for charity.");
                    break;
                }
                counter++;
            }
        }
    }
}
