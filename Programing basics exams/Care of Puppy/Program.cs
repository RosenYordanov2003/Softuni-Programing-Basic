using System;

namespace Care_of_Puppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine()) * 1000;
            string comand = String.Empty;
            int eatenFood = 0;
            int total = 0;
            while ((comand = Console.ReadLine()) != "Adopted")
            {
                eatenFood = int.Parse(comand);
                food -= eatenFood;
            }
            if (food >= 0)
            {
                Console.WriteLine($"Food is enough! Leftovers: {food} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(food)} grams more.");
            }
        }
    }
}
