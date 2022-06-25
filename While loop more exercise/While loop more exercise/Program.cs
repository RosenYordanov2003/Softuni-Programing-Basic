using System;

namespace While_loop_more_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countBootles = int.Parse(Console.ReadLine());
            countBootles = 750 * countBootles;
            string comand = string.Empty;
            int countCourt = 0;
            int countPotwashed = 0;
            int tend = 0;
            int counter = 0;
            while ((comand = Console.ReadLine()) != "End")
            {
                counter++;
                if (counter % 3 == 0)
                {
                    countCourt = int.Parse(comand);
                    countBootles -= countCourt * 15;
                    tend += countCourt;
                }
                else
                {
                    countCourt = int.Parse(comand);
                    countPotwashed += countCourt;
                    countBootles -= 5 * countCourt;
                }
                if (countBootles < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(countBootles)} ml. more necessary!");
                    return;

                }
            }
            Console.WriteLine("Detergent was enough! ");
            Console.WriteLine($"{countPotwashed} dishes and {tend} pots were washed.");
            Console.WriteLine($"Leftover detergent {countBootles} ml.");
        }
    }
}
