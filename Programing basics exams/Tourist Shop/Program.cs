using System;

namespace Tourist_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double productTotal = 0;
            int countProducts = 0;
            string product = string.Empty;
            while (true)
            {
                product = Console.ReadLine();
                if (product == "Stop")
                {
                    Console.WriteLine($"You bought {countProducts} products for {productTotal:f2} leva.");
                    break;
                }
                double productPrice = double.Parse(Console.ReadLine());
                countProducts++;

                if (countProducts % 3 == 0)
                {
                    productPrice = productPrice - (productPrice * 50) / 100;
                }
                if (productPrice > budget)
                {
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {Math.Abs(budget - productPrice):f2} leva!");
                    break;
                }
                budget -= productPrice;
                productTotal += productPrice;
            }
        }
    }
}
