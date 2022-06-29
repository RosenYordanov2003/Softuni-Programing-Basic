using System;

namespace Club
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mooney = double.Parse(Console.ReadLine());
            string comand = Console.ReadLine();
            double totalPrice = 0;
            while (comand != "Party!")
            {
                int count = int.Parse(Console.ReadLine());
                double price = comand.Length;
                price = price * count;

                if (price % 2 != 0)
                {
                    price = price - (price * 25) / 100;
                }
                totalPrice += price;

                if (totalPrice >= mooney)
                {
                    Console.WriteLine("Target acquired.");
                    break;
                }
                comand = Console.ReadLine();

            }
            if (comand == "Party!")
            {
                double mooneyNeed = Math.Abs(mooney - totalPrice);
                Console.WriteLine($"We need {mooneyNeed:f2} leva more.");
            }
            Console.WriteLine($"Club income - {totalPrice:f2} leva.");
        }
    }
}
