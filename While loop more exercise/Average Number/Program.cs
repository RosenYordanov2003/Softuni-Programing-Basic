using System;

namespace Average_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum += num;

            }
            double av = sum / n;
            Console.WriteLine($"{av:f2}");
        }
    }
}
