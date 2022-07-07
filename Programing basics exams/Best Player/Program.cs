using System;

namespace Best_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int goals = 0;
            string bestPlayer = string.Empty;
            int maxGoals = int.MinValue;
            while (name != "END")
            {
                goals = int.Parse(Console.ReadLine());
                if (name == "END")
                {
                    break;
                }
                if (goals > maxGoals)
                {
                    maxGoals = goals;
                    bestPlayer = name;
                }
                if (goals >= 10)
                {
                    break;
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"{bestPlayer} is the best player!");
            if (goals >= 3)
            {
                Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {maxGoals} goals.");
            }
        }
    }
}
