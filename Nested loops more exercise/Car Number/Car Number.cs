using System;

namespace Car_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                for (int z = start; z <= end; z++)
                {
                    for (int k = start; k <= end; k++)
                    {
                        for (int x = start; x <= end; x++)
                        {
                            int firstDigit = i % 10;
                            int secondDigit = z % 10;
                            int thirdDigit = k % 10;
                            int fourthDigit = x % 10;
                            int sum = secondDigit + thirdDigit;
                            if ((firstDigit % 2 == 0 && fourthDigit % 2 != 0 || firstDigit % 2 != 0 && fourthDigit % 2 == 0) && (firstDigit > fourthDigit) && (sum % 2 == 0))
                            {
                                Console.Write($"{i}{z}{k}{x} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
