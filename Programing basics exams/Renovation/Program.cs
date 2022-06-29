using System;

namespace Renovation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h = int.Parse(Console.ReadLine());
            double w = int.Parse(Console.ReadLine());
            double percent = int.Parse(Console.ReadLine());
            double walls = 4 * h * w;
            percent = Math.Ceiling(walls - (walls * percent) / 100);
            //  percent = Math.Ceiling(percent);
            string comand = Console.ReadLine();
            while (comand != "Tired!")
            {
                double countPaint = double.Parse(comand);

                percent -= countPaint;
                if (percent <= 0)
                {
                    break;
                }
                comand = Console.ReadLine();
            }
            if (percent == 0)
            {
                Console.WriteLine("All walls are painted! Great job, Pesho!");
            }
            if (comand == "Tired!")
            {
                Console.WriteLine($"{percent} quadratic m left.");
            }
            else
            {
                Console.WriteLine($"All walls are painted and you have {Math.Abs(percent)} l paint left!");
            }
        }
    }
}
