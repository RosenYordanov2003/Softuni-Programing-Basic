using System;

namespace Skeleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double secondsper100Meteer = double.Parse(Console.ReadLine());
            int controlTime = minutes * 60 + seconds;
            double countLate = lenght / 120;
            double lateTime = countLate * 2.5;
            double marinTime = (lenght / 100) * secondsper100Meteer - lateTime;
            if (marinTime <= controlTime)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {marinTime:f3}.");
            }
            else
            {
                double diff = Math.Abs(controlTime - marinTime);
                Console.WriteLine($"No, Marin failed! He was {diff:f3} second slower.");
            }
        }
    }
}
