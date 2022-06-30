using System;

namespace Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = string.Empty;
            double studentTicket = 0;
            double standardTicket = 0;
            double kidTicket = 0;
            double seatsAfterMovie = 0;
            double totalTickets = 0;
            int seats = 0;
            double totalTickets2 = 0;
            while (movie != "Finish")
            {
                movie = Console.ReadLine();
                if (movie == "Finish")
                {
                    break;
                }
                seats = int.Parse(Console.ReadLine());
                for (int i = 1; i <= seats; i++)
                {
                    string typeTickets = Console.ReadLine();
                    if (typeTickets == "End")
                    {
                        break;
                    }
                    if (typeTickets == "standard")
                    {
                        standardTicket++;
                        totalTickets++;
                        totalTickets2++;
                    }
                    else if (typeTickets == "kid")
                    {
                        kidTicket++;
                        totalTickets++;
                        totalTickets2++;
                    }
                    else if (typeTickets == "student")
                    {
                        studentTicket++;
                        totalTickets++;
                        totalTickets2++;
                    }
                }
                seatsAfterMovie = (totalTickets / seats) * 100;
                Console.WriteLine($"{movie} - {seatsAfterMovie:f2}% full.");
                totalTickets = 0;
                seatsAfterMovie = 0;
            }
            double percentStudents = studentTicket / totalTickets2 * 100;
            double percentKids = kidTicket / totalTickets2 * 100;
            double percentStandards = standardTicket / totalTickets2 * 100;
            Console.WriteLine($"Total tickets: {totalTickets2}");
            Console.WriteLine($"{percentStudents:f2}% student tickets.");
            Console.WriteLine($"{percentStandards:f2}% standard tickets.");
            Console.WriteLine($"{percentKids:f2}% kids tickets.");
        }
    }
}
