using System;

namespace Food_for_Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            float food = float.Parse(Console.ReadLine());
            double biscuites = 0;
            double Totalbiscuites = 0;
            double totalDog = 0;
            double totalCat = 0;
            double totalFood = 0;
            for (int i = 1; i <= days; i++)
            {
                int eatenFoodbyDog = int.Parse(Console.ReadLine());
                int eatenFoodbyCat = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    double foodforday = eatenFoodbyCat + eatenFoodbyDog;
                    biscuites = (foodforday * 10) / 100;
                    Totalbiscuites += biscuites;
                }
                totalDog += eatenFoodbyDog;
                totalCat += eatenFoodbyCat;

                totalFood = totalCat + totalDog;

            }
            double totalFoodP = (totalFood / food) * 100;
            double dogP = (totalDog / totalFood) * 100;
            double catP = (totalCat / totalFood) * 100;
            Console.WriteLine($"Total eaten biscuits: {Math.Round(Totalbiscuites)}gr.");
            Console.WriteLine($"{totalFoodP:f2}% of the food has been eaten.");
            Console.WriteLine($"{dogP:f2}% eaten from the dog.");
            Console.WriteLine($"{catP:f2}% eaten from the cat.");
        }
    }
}
