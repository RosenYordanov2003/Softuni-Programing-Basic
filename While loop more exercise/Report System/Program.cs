using System;

namespace Report_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moneyNeed = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int cashCounter = 0;
            int creditCardUsersCounter = 0;
            int counter = 0;
            double totalSum = 0;
            double sumFromCard = 0;
            double sumByCash = 0;
            while (input != "End")
            {
                int priceMoney = int.Parse(input);
                if (counter % 2 == 0)
                {
                    if (priceMoney > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        sumByCash += priceMoney;
                        cashCounter++;
                    }
                }
                else
                {
                    if (priceMoney < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        sumFromCard += priceMoney;
                        creditCardUsersCounter++;
                    }
                }
                totalSum = sumFromCard + sumByCash;
                if (totalSum >= moneyNeed)
                {
                    Console.WriteLine($"Average CS: {sumByCash / cashCounter:f2}");
                    Console.WriteLine($"Average CC: {sumFromCard / creditCardUsersCounter:f2}");
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
