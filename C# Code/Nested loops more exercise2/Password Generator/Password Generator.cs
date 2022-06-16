using System;

namespace Password_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n_Number = int.Parse(Console.ReadLine());
            int l_number = int.Parse(Console.ReadLine());
            int letter = 97 + l_number;
            for (int i = 1; i <= n_Number; i++)
            {
                for (int j = 1; j <= n_Number; j++)
                {
                    for (int k = 97; k < letter; k++)
                    {
                        for (int o = 97; o < letter; o++)
                        {
                            for (int z = j + 1; z <= n_Number; z++)
                            {
                                if (z > i && z > j)
                                {
                                    Console.Write($"{i}{j}{(char)(k)}{(char)(o)}{z} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
