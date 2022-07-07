using System;

namespace Add_Bags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                double luggageOver20kg = double.Parse(Console.ReadLine());
                double kg = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int countluggage = int.Parse(Console.ReadLine());
                double sum = 0;
                if (kg < 10)
                {
                    sum = (luggageOver20kg * 20) / 100;
                }
                else if (kg >= 10 && kg <= 20)
                {
                    sum = (luggageOver20kg * 50) / 100;
                }
                else if (kg >= 20)
                {
                    sum = luggageOver20kg;
                }
                if (days > 30)
                {
                    sum = sum + (sum * 10) / 100;
                }
                else if (days >= 7 && days <= 30)
                {
                    sum = sum + (sum * 15) / 100;
                }
                else if (days <= 7)
                {
                    sum = sum + (sum * 40) / 100;
                }
                sum = sum * countluggage;

                Console.WriteLine($" The total price of bags is: {sum:f2} lv.");
            }
        }
    }
}
