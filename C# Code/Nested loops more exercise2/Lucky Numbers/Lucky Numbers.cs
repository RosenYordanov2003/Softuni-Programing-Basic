using System;

namespace Lucky_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                for (int z = 1; z <= 9; z++)
                {
                    for (int x = 1; x <= 9; x++)
                    {
                        for (int g = 1; g <= 9; g++)
                        {
                            int firstDigit = i % 10;
                            int secondDigit = z % 10;
                            int thirdDigit = x % 10;
                            int fourthDigit = g % 10;
                            int sum1 = firstDigit + secondDigit;
                            int sum2 = thirdDigit + fourthDigit;
                            if ((sum1 == sum2) && (n % sum1 == 0))
                            {
                                Console.Write($"{i}{z}{x}{g} ");
                            }

                        }
                    }
                }
            }
        }
    }
}
