using System;

namespace Name_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string names = string.Empty;
            int charLetter = 0;
            int max = 0;
            int sum = 0;
            string winner = string.Empty;
            while (true)
            {
                names = Console.ReadLine();
                if (names == "Stop")
                {
                    break;
                }
                for (int i = 0; i < names.Length; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    charLetter = (int)(names[i]);
                    if (num == charLetter)
                    {
                        sum += 10;

                    }
                    else
                    {
                        sum += 2;
                    }
                }
                if (sum >= max)
                {
                    max = sum;
                    winner = names;
                }
                sum = 0;
            }
            Console.WriteLine($"The winner is {winner} with {max} points!");
        }
    }
}
