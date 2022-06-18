using System;

namespace Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());

            for (int i = f; i > 0; i--)
            {
                for (int j = 0; j < r; j++)
                {
                    if (i == f)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{j} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
