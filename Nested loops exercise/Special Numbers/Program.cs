using System;

namespace Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isfind = false;
            for (int z = 1; z <= 9; z++)
            {
                for (int g = 1; g <= 9; g++)
                {
                    for (int x = 1; x <= 9; x++)
                    {
                        for (int y = 1; y < 9; y++)
                        {
                            if (n % z == 0 && n % g == 0 && n % x == 0 && n % y == 0)
                            {
                                isfind = true;
                                Console.Write($"{z}{g}{x}{y} ");


                            }
                        }
                    }
                }
            }

        }
    }
}

        
    

