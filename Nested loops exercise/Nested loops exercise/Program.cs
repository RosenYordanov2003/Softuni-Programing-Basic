using System;

namespace Nested_loops_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentPosition = 1;
            bool isbigger = false;
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(currentPosition + " ");
                    currentPosition++;
                    if (currentPosition > n)
                    {
                        isbigger = true;
                        break;
                    }

                }
                Console.WriteLine();
                if (isbigger)
                {
                    break;
                }
            }
        }
    }
}
