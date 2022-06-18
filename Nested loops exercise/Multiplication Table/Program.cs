using System;

namespace Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    sum = i * j;
                    Console.WriteLine($"{i} * {j} = {sum}");
                }
            }
        }
    }
}
