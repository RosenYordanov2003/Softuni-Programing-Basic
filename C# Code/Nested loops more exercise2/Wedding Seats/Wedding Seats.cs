using System;

namespace Wedding_Seats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sector = char.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            int oddSeats = int.Parse(Console.ReadLine());
            int counter = 0;
            int letter = 0;
            int counter2 = 0;
            int total = 0;
            for (char i = 'A'; i <= sector; i++, rows++)
            {
                for (int j = 1; j <= rows; j++)
                {

                    if (j % 2 != 0)
                    {
                        letter = 97 + oddSeats;
                        for (int z = 97; z <= letter - 1; z++)
                        {
                            Console.WriteLine($"{i}{j}{(char)(z)}");
                            counter++;

                        }
                    }
                    else if (j % 2 == 0)
                    {
                        int evenSetas = 0;
                        evenSetas = oddSeats + 2;
                        int secondLetter = 97 + evenSetas;
                        for (int z = 97; z <= secondLetter - 1; z++)
                        {
                            Console.WriteLine($"{i}{j}{(char)(z)}");
                            counter2++;
                        }
                    }
                }
            }
            total = counter + counter2;
            Console.WriteLine(total);
        }
    }
    
}
