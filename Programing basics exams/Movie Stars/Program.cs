using System;

namespace Movie_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            double salary = 0;
            while (name != "ACTION")
            {
                int namelenght = name.Length;
                if (namelenght > 15)
                {
                    budget -= (budget * 20) / 100;
                }
                else
                {
                    salary = double.Parse(Console.ReadLine());
                    budget -= salary;
                }
                if (budget <= 0)
                {
                    Console.WriteLine($"We need {Math.Abs(budget):f2} leva for our actors.");
                    return;
                }
                name = Console.ReadLine();
            }
            if (budget > 0)
            {
                Console.WriteLine($"We are left with {budget:f2} leva.");
            }
        }
    }
}
