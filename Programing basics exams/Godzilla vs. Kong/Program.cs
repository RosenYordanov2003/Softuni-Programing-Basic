using System;

namespace Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countStatist = int.Parse(Console.ReadLine());
            double clothes = double.Parse(Console.ReadLine());
            double dekor = (budget * 10) / 100;
            double statistSum = countStatist * clothes;
            if (countStatist > 150)
            {
                statistSum = statistSum - (statistSum * 10) / 100;
            }
            double total = statistSum + dekor;
            if (budget >= total)
            {
                double mooneyLeft = budget - total;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {mooneyLeft:f2} leva left.");
            }
            else
            {
                double mooneyNeed = Math.Abs(budget - total);
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {mooneyNeed:f2} leva more.");
            }
        }
    }
}
