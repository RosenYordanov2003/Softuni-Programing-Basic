using System;

namespace Secret_Door_s_Lock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            for (int i = 1; i <= first; i++)
            {
                for (int g = 1; g <= second; g++)
                {
                    for (int r = 2; r <= third; r++)
                    {
                        int firstDigit = i % 10;
                        int secondDigit = g % 10;
                        int thirdDigit = r % 10;
                        if ((thirdDigit % 2 == 0 && firstDigit % 2 == 0) && (secondDigit == 2 || secondDigit == 3 || secondDigit == 5 || secondDigit == 7))
                        {
                            Console.WriteLine($"{i} {g} {r} ");
                        }


                    }
                }
            }
        }
    }
}
