using System;

namespace Vegetable_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double euro = 1.94;
            double priceVeg = double.Parse(Console.ReadLine());
            double priceFruit = double.Parse(Console.ReadLine());
            int kgVeg = int.Parse(Console.ReadLine());
            int kgFruit = int.Parse(Console.ReadLine());
            double totalVegPrice = priceVeg * kgVeg;
            double totalFruitPrice = priceFruit * kgFruit;
            double total = totalFruitPrice + totalVegPrice;
            double totalinEuro = total / euro;
            Console.WriteLine($"{totalinEuro:f2}");
        }
    }
}
