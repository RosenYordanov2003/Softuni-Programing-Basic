using System;

namespace Tournament_of_Christmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string sport = string.Empty;
            string results = string.Empty;
            double mooney = 0;
            int countWins = 0;
            int countLoses = 0;
            double total = 0;
            int totalWins = 0;
            int totalloses = 0;
            for (int i = 1; i <= days; i++)
            {
                while ((sport=Console.ReadLine())!="Finish")
                {
                    results = Console.ReadLine();
                    if (results == "win")
                    {
                        countWins++;
                        mooney += 20;
                    }
                    if (results == "lose")
                    {
                        countLoses++;
                    }
                }
                if (countWins > countLoses)
                {
                    mooney = mooney + (mooney * 10) / 100;
                }
                total += mooney;
                mooney = 0;
                totalloses += countLoses;
                totalWins += countWins;
                countWins = 0;
                countLoses = 0;
            }
            if (totalWins > totalloses)
            {
                total = total + (total * 20) / 100;
                Console.WriteLine($"You won the tournament! Total raised money: {total:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {total:f2}");
            }
        }
    }
}
