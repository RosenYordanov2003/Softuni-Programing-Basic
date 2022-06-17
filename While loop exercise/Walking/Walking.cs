using System;

namespace Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int goal = 10000;
            string comand = string.Empty;
            int total = 0;
            int steps = 0;
            while (total < goal)
            {
                comand = Console.ReadLine();
                if (comand == "Going home")
                {
                    int bonusSteps = int.Parse(Console.ReadLine());
                    total += bonusSteps;
                    break;
                }
                else
                {
                    steps = int.Parse(comand);
                    total += steps;
                }
            }
            if (total >= goal)
            {
                int diff = Math.Abs(total - goal);
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{diff} steps over the goal!");
            }
            else
            {
                int stepsNeed = goal - total;
                Console.WriteLine($"{stepsNeed} more steps to reach goal.");
            }
        }
    }
}
