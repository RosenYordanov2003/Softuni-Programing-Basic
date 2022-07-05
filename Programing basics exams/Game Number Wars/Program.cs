using System;

namespace Game_Number_Wars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string player1 = Console.ReadLine();
            string player2 = Console.ReadLine();
            string comand = Console.ReadLine();
            int pointsplayer1 = 0;
            int pointsplayer2 = 0;
            while (comand != "End of game")
            {
                int player1card = int.Parse(comand);
                int player2card = int.Parse(Console.ReadLine());
                if (player1card > player2card)
                {
                    pointsplayer1 += Math.Abs(player2card - player1card);
                }
                else if (player1card < player2card)
                {
                    pointsplayer2 += Math.Abs(player1card - player2card);
                }
                else if (player1card == player2card)
                {
                    Console.WriteLine("Number wars!");
                    int bonuscardplayer1 = int.Parse(Console.ReadLine());
                    int bonuscardplayer2 = int.Parse(Console.ReadLine());
                    if (bonuscardplayer1 < bonuscardplayer2)
                    {

                        Console.WriteLine($"{player2} is winner with {pointsplayer2} points");
                        break;
                    }
                    else if (bonuscardplayer1 > bonuscardplayer2)
                    {

                        Console.WriteLine($"{player1} is winner with {pointsplayer1} points");
                        break;
                    }
                }
                comand = Console.ReadLine();
                if (comand == "End of game")
                {
                    Console.WriteLine($"{player1} has {pointsplayer1} points");
                    Console.WriteLine($"{player2} has {pointsplayer2} points");
                    break;
                }
            }
        }
    }
}
