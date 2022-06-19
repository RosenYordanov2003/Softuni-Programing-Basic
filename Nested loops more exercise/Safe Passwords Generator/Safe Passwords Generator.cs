using System;

namespace Safe_Passwords_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            bool ready = false;
            int countCombination = 0;
            for (int A = 35; A <= 55; A++)
            {
                for (int B = 64; B <= 96; B++)
                {
                    for (int x = 1; x <= a; x++)
                    {
                        for (int y = 1; y <= b; y++)
                        {
                            countCombination++;

                            if (countCombination > count)
                            {
                                ready = true;
                                break;
                            }
                            if (A > 55)
                            {
                                A = 35;
                            }
                            if (B > 96)
                            {
                                B = 64;
                            }
                            Console.Write($"{(char)(A)}{(char)(B)}{x}{y}{(char)(B)}{(char)(A)}|");
                            if (x == a && y == b)
                            {
                                ready = true;
                                break;

                            }
                            A++;
                            B++;
                        }
                        if (ready)
                        {
                            break;
                        }
                    }
                    if (ready)
                    {
                        break;
                    }

                }
                if (ready)
                {
                    break;

                }
                if (ready)
                {
                    break;
                }
            }
        }
    }
}
