using System;

namespace Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countgroups = int.Parse(Console.ReadLine());

            int rila = 0;
            int k2 = 0;
            int kilim = 0;
            int everest = 0;
            int molban = 0;
            for (int i = 0; i < countgroups; i++)
            {
                int countofclimbers = int.Parse(Console.ReadLine());
                if (countofclimbers <= 5)
                {
                    rila += countofclimbers;
                }
                else if (countofclimbers >= 6 && countofclimbers <= 12)
                {
                    molban += countofclimbers;
                }
                else if (countofclimbers >= 13 && countofclimbers <= 25)
                {
                    kilim += countofclimbers;
                }
                else if (countofclimbers >= 26 && countofclimbers <= 40)
                {
                    k2 += countofclimbers;
                }
                else if (countofclimbers >= 41)
                {
                    everest += countofclimbers;
                }
            }
            double clim = rila + molban + kilim + k2 + everest;
            double p1rila = rila / clim * 100;
            double p2mol = molban / clim * 100;
            double p3kilim = kilim / clim * 100;
            double p4k2 = k2 / clim * 100;
            double p5everest = everest / clim * 100;
            Console.WriteLine($"{p1rila:f2}%");
            Console.WriteLine($"{p2mol:f2}%");
            Console.WriteLine($"{p3kilim:f2}%");
            Console.WriteLine($"{p4k2:f2}%");
            Console.WriteLine($"{p5everest:f2}%");

        }
    }
}
