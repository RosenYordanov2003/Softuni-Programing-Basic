using System;

namespace Division_Without_Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            for (int i = 1; i <= n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers % 2 == 0)
                {
                    p1++;
                }
                if (numbers % 3 == 0)
                {
                    p2++;
                }
                if (numbers % 4 == 0)
                {
                    p3++;
                }
            }
            double p1P = p1 / n * 100;
            double p2P = p2 / n * 100;
            double p3P = p3 / n * 100;
            Console.WriteLine($"{p1P:f2}%");
            Console.WriteLine($"{p2P:f2}%");
            Console.WriteLine($"{p3P:f2}%");
        }
    }
}
