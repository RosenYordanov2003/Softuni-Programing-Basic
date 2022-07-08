using System;

namespace Energy_Booster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double sum = 0;
            if (size == "small")
            {
                if (Fruit == "Watermelon")
                {
                    sum = 56 * 2;
                }
                else if (Fruit == "Mango")
                {
                    sum = 36.66 * 2;
                }
                else if (Fruit == "Pineapple")
                {
                    sum = 42.10 * 2;
                }
                else if (Fruit == "Raspberry")
                {
                    sum = 20 * 2;
                }
            }
            else if (size == "big")
            {
                if (Fruit == "Watermelon")
                {
                    sum = 28.70 * 5;
                }
                else if (Fruit == "Mango")
                {
                    sum = 19.60 * 5;
                }
                else if (Fruit == "Pineapple")
                {
                    sum = 24.80 * 5;
                }
                else if (Fruit == "Raspberry")
                {
                    sum = 15.20 * 5;
                }
            }
            sum *= count;
            if (sum >= 400 & sum <= 1000)
            {
                sum = sum - (sum * 15) / 100;
            }
            else if (sum > 1000)
            {
                sum = sum - (sum * 50) / 100;
            }
            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
