using System;

namespace Oskars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double pointsfromacademy = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double totalpointsfromjuri = 0;
            for (int i = 0; i < n; i++)
            {
                string juri = Console.ReadLine();
                double pointsfromjuri = double.Parse(Console.ReadLine());
                double numberchar = juri.Length;
                totalpointsfromjuri = (pointsfromjuri * numberchar) / 2;
                pointsfromacademy += totalpointsfromjuri;
                if (pointsfromacademy >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {pointsfromacademy:f1}!");
                    break;
                }
            }
            if (pointsfromacademy < 1250.5)
            {
                double pointsneed = Math.Abs(pointsfromacademy - 1250.5);
                Console.WriteLine($"Sorry, {actor} you need {pointsneed:f1} more!");
            }
        }
    }
}
