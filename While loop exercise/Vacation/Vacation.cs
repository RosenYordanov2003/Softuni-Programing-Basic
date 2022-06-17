using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeed = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());
            string action = string.Empty;
            int spendCounter = 0;
            int days = 0;
            while (currentMoney < moneyNeed)
            {
                action = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                if (action == "save")
                {
                    currentMoney += sum;
                    spendCounter = 0;
                    days++;
                }
                else
                {
                    currentMoney -= sum;
                    spendCounter++;
                    days++;
                }
                if (currentMoney < 0)
                {
                    currentMoney = 0;
                }
                if (spendCounter == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{days}");
                    return;
                }
            }
            Console.WriteLine($"You saved the money for {days} days.");
        }
    }
}
