using System;

namespace Easter_Eggs_Battle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerOneEggs = int.Parse(Console.ReadLine());
            int secondPlayerEggs = int.Parse(Console.ReadLine());

            while (true)
            {
                string txt = Console.ReadLine();
                if (txt == "one")
                {
                    secondPlayerEggs--;
                }
                else if (txt == "two")
                {
                    playerOneEggs--;
                }
                if (txt == "End of battle")
                {
                    Console.WriteLine($"Player one has {playerOneEggs} eggs left.");
                    Console.WriteLine($"Player two has {secondPlayerEggs} eggs left.");
                    break;
                }
                if (secondPlayerEggs == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {playerOneEggs} eggs left.");
                    return;
                }
                if (playerOneEggs == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {secondPlayerEggs} eggs left.");
                    return;
                }
            }
        }
    }
}
