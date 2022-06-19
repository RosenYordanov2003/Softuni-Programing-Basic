using System;

namespace Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count1LevCoins = int.Parse(Console.ReadLine());
            int count2LevCoins = int.Parse(Console.ReadLine());
            int count5LevCoins = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
            for (int i = 0; i <= count1LevCoins; i++)
            {
                for (int z = 0; z <= count2LevCoins; z++)
                {
                    for (int g = 0; g <= count5LevCoins; g++)
                    {

                        if (i * 1 + z * 2 + g * 5 == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {z} * 2 lv. + {g} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
