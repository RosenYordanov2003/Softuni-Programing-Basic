using System;

namespace Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int totalPieces = lenght * width;
            string comand = string.Empty;
            while (totalPieces > 0)
            {
                comand = Console.ReadLine();
                if (comand == "STOP")
                {
                    break;
                }
                int cakesGet = int.Parse(comand);
                totalPieces -= cakesGet;
                if (totalPieces < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
                    return;
                }
            }
            Console.WriteLine($"{totalPieces} pieces are left.");
        }
    }
    
}
