using System;

namespace for_loop_more_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            double yearsold = 17;
            for (int i = 1800; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money = money - 12000;
                }
                else if (i % 2 != 0)
                {
                    yearsold += 2;
                    money = money - (12000 + (50 * yearsold));
                }
            }
            if (money >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {money:f2} dollars left.");
            }
            else
            {
                money = Math.Abs(money);
                Console.WriteLine($"He will need {money:f2} dollars to survive.");
            }
        }
    }
}
