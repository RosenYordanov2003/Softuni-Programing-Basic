using System;

namespace Easter_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eggs = int.Parse(Console.ReadLine());
            int soldEggs = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Close")
                {
                    Console.WriteLine("Store is closed!");
                    Console.WriteLine($"{soldEggs} eggs sold.");
                    break;
                }
                int eggsCounter = int.Parse(Console.ReadLine());
                if (command == "Fill")
                {
                    eggs += eggsCounter;
                }
                if (command == "Buy")
                {
                    if (eggs >= eggsCounter)
                    {
                        eggs -= eggsCounter;
                        soldEggs += eggsCounter;
                    }
                    else
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {eggs}.");
                        break;
                    }
                }
            }
        }
    }
}
