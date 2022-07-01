using System;

namespace Movie_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int i = a1; i <= a2 - 1; i++)
            {
                for (int z = 1; z <= n - 1; z++)
                {
                    for (int g = 1; g <= n / 2 - 1; g++)
                    {
                        int firstDigit = i % 10;
                        int SecondDigit = z % 10;
                        int thirdDigit = g % 10;
                        int sum = firstDigit + SecondDigit + thirdDigit;
                        if (i % 2 != 0 && sum % 2 != 0)
                        {
                            Console.WriteLine($"{(char)(i)}-{z}{g}{i}");
                        }
                    }
                }
            }
        }
    }
}
