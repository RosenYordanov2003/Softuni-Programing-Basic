using System;

namespace Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string tema = string.Empty;
            double totalGrades = 0;
            double average = 0;
            double totalAv = 0;
            int temaCount = 0;
            while (tema != "Finish")
            {
                tema = Console.ReadLine();
                if (tema == "Finish")
                {
                    break;
                }
                for (int i = 1; i <= n; i++)
                {
                    double gardes = double.Parse(Console.ReadLine());
                    totalGrades += gardes;
                    average = totalGrades / n;


                }
                Console.WriteLine($"{tema} - {average:f2}.");
                totalAv += average;
                totalGrades = 0;
                average = 0;
                temaCount++;
            }

            Console.WriteLine($"Student's final assessment is {totalAv / temaCount:f2}.");
        }
    }
    
}
