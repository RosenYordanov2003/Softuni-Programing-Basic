using System;

namespace Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int max = int.MinValue;
            while (comand != "Stop")
            {
               int number = int.Parse(comand);
                if (number > max)
                {
                    max = number;
                }
                comand = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
