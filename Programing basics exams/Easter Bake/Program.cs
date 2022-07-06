using System;

namespace Easter_Bake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int easterBreads = int.Parse(Console.ReadLine());
            double maxsugar = int.MinValue;
            double maxflour = int.MinValue;
            double totalSugar = 0;
            double totalFlour = 0;
            for (int i = 1; i <= easterBreads; i++)
            {
                double sugarGram = int.Parse(Console.ReadLine());
                double flourGramm = int.Parse(Console.ReadLine());
                totalFlour += flourGramm;
                totalSugar += sugarGram;
                if (sugarGram > maxsugar)
                {
                    maxsugar = sugarGram;
                }
                if (flourGramm > maxflour)
                {
                    maxflour = flourGramm;
                }
            }
            double needPacketsflour = Math.Ceiling(totalFlour / 750);
            double needPacketSugar = Math.Ceiling(totalSugar / 950);
            Console.WriteLine($"Sugar: {needPacketSugar}");
            Console.WriteLine($"Flour: {needPacketsflour}");
            Console.WriteLine($"Max used flour is {maxflour} grams, max used sugar is {maxsugar} grams.");
        }
    }
}
