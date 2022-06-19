using System;

namespace Letters_Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstL = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char thirdL = char.Parse(Console.ReadLine());
            int count = 0;
            for (char i = firstL; i <= end; i++)
            {
                for (char j = firstL; j <= end; j++)
                {
                    for (char k = firstL; k <= end; k++)
                    {
                        if (i == thirdL || j == thirdL || k == thirdL)
                        {
                            continue;

                        }
                        else
                        {
                            count++;
                            Console.Write($"{i}{j}{k} ");

                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
