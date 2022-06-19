using System;

namespace Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int count = 0;
            int currentSum = 0;
            bool magicNumberFound = false;
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    count++;
                    currentSum = i + j;
                    if (currentSum == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magicNumber})");
                        magicNumberFound = true;
                        break;
                    }
                }
                if (magicNumberFound)
                {
                    break;
                }
            }
            if (currentSum != magicNumber)
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
            }
        }
    }
}
