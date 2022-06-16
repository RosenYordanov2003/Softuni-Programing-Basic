using System;

namespace Challenge_the_Wedding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countmen = int.Parse(Console.ReadLine());
            int countwomen = int.Parse(Console.ReadLine());
            int countTables = int.Parse(Console.ReadLine());
            int count = 0;
            string couples = string.Empty;
            for (int i = 1; i <= countmen; i++)
            {
                for (int x = 1; x <= countwomen; x++)
                {
                    count++;


                    if (count == countTables)
                    {
                        Console.Write($"({i} <-> {x}) ");
                        return;
                    }
                    Console.Write($"({i} <-> {x}) ");
                }
            }
        }
    }
}
