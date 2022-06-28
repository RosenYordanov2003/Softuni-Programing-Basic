using System;

namespace Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countGroups = int.Parse(Console.ReadLine());
            double totalPeople = 0;
            double countMusala = 0;
            double countK2 = 0;
            double countMonblan = 0;
            double countEverest = 0;
            double countKlim = 0;
            for (int i = 1; i <= countGroups; i++)
            {
                double people = int.Parse(Console.ReadLine());
                if (people <= 5)
                {
                    countMusala += people;
                }
                else if (people >= 6 && people <= 12)
                {
                    countMonblan += people;
                }
                else if (people >= 13 && people <= 25)
                {
                    countKlim += people;
                }
                else if (people >= 26 && people <= 40)
                {
                    countK2 += people;
                }
                else if (people >= 41)
                {
                    countEverest += people;
                }
                totalPeople += people;
            }
            double musalaP = (countMusala / totalPeople) * 100;
            double EverestP = (countEverest / totalPeople) * 100;
            double k2p = (countK2 / totalPeople) * 100;
            double monbalnP = (countMonblan / totalPeople) * 100;
            double KILMp = (countKlim / totalPeople) * 100;
            Console.WriteLine($"{musalaP:f2}%");
            Console.WriteLine($"{monbalnP:f2}%");
            Console.WriteLine($"{KILMp:f2}%");
            Console.WriteLine($"{k2p:f2}%");
            Console.WriteLine($"{EverestP:f2}%");
        }
    }
}
