using System;

namespace Fitness_Center
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double back = 0;
            double chest = 0;
            double protein = 0;
            double legs = 0;
            double proteinbar = 0;
            double proteinshake = 0;
            double abs = 0;
            double workout = 0;
            double n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string practice = Console.ReadLine();
                if (practice == "Back")
                {
                    back++;
                    workout++;
                }
                else if (practice == "Abs")
                {
                    abs++;
                    workout++;
                }
                else if (practice == "Chest")
                {
                    chest++;
                    workout++;
                }
                else if (practice == "Legs")
                {
                    legs++;
                    workout++;
                }
                else if (practice == "Protein bar")
                {

                    proteinbar++;
                    protein++;
                }
                else if (practice == "Protein shake")
                {
                    proteinshake++;
                    protein++;
                }
            }
            workout = (workout / n) * 100;
            protein = (protein / n) * 100;
            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{proteinshake} - protein shake");
            Console.WriteLine($"{proteinbar} - protein bar");
            Console.WriteLine($"{workout:f2}% - work out");
            Console.WriteLine($"{protein:f2}% - protein");
        }
    }
}
