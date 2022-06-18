using System;

namespace Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            string currentNum = string.Empty;
            int currentDigit = 0;
            for (int i = firstNum; i <= secondNum; i++)
            {
                currentNum = i.ToString();
                int odd = 0;
                int even = 0;
                for (int z = 0; z < currentNum.Length; z++)
                {
                    currentDigit = int.Parse(currentNum[z].ToString());
                    if (z % 2 == 0)
                    {
                        even += currentDigit;
                    }
                    else
                    {
                        odd += currentDigit;
                    }

                }
                if (even == odd)
                {
                    Console.Write($"{i} ");
                }

            }
        }
    }
}
