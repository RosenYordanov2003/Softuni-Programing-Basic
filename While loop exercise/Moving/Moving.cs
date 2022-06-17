using System;

namespace Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int widht = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int total = widht * lenght * height;
            string comand = string.Empty;
            while (total > 0)
            {
                comand = Console.ReadLine();
                if (comand == "Done")
                {
                    break;
                }
                int boxes = int.Parse(comand);
                total -= boxes;
                if (total < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(total)} Cubic meters more.");
                    return;
                }
            }
            Console.WriteLine($"{total} Cubic meters left.");
        }
    }
}
