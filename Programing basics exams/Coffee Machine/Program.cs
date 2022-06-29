using System;

namespace Coffee_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string sugar = Console.ReadLine();
            double count = int.Parse(Console.ReadLine());
            double price = 0;
            if (type == "Espresso")
            {
                if (sugar == "Normal")
                {
                    price = 1 * count;
                }
                else if (sugar == "Without")
                {
                    price = 0.90 * count;
                    price = price - (price * 35) / 100;
                }
                else if (sugar == "Extra")
                {
                    price = 1.20 * count;
                }
            }
            else if (type == "Cappuccino")
            {
                if (sugar == "Normal")
                {
                    price = 1.20 * count;
                }
                else if (sugar == "Without")
                {
                    price = 1 * count;
                    price = price - (price * 35) / 100;
                }
                else if (sugar == "Extra")
                {
                    price = 1.60 * count;
                }
            }
            else if (type == "Tea")
            {
                if (sugar == "Normal")
                {
                    price = 0.60 * count;
                }
                else if (sugar == "Without")
                {
                    price = 0.50 * count;
                    price = price - (price * 35) / 100;
                }
                else if (sugar == "Extra")
                {
                    price = 0.70 * count;
                }
            }
            if (type == "Espresso" && count >= 5)
            {
                price = price - (price * 25) / 100;
            }
            if (price > 15)
            {
                price = price - (price * 20) / 100;
            }
            Console.WriteLine($"You bought {count} cups of {type} for {price:f2} lv.");
        }
    }
}
