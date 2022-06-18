using System;

namespace Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filmname = "";
            double totalstudent = 0;
            double totalstandard = 0;
            double totalkid = 0;
            double totalticket = 0;
            while (filmname != "Finish")
            {
                filmname = Console.ReadLine();
                double studentticket = 0;
                double standardticket = 0;
                double kidticket = 0;
                if (filmname == "Finish")
                {
                    break;

                }
                double places = int.Parse(Console.ReadLine());
                for (int i = 0; i < places; i++)
                {
                    string typeoftickets = Console.ReadLine();
                    if (typeoftickets == "standard")
                    {
                        standardticket++;

                    }
                    else if (typeoftickets == "student")
                    {
                        studentticket++;

                    }
                    else if (typeoftickets == "kid")
                    {
                        kidticket++;

                    }
                    else if (typeoftickets == "End")
                    {

                        break;
                    }

                }
                totalstandard += standardticket;
                totalstudent += studentticket;
                totalkid += kidticket;
                Console.WriteLine($"{filmname} - {((studentticket + standardticket + kidticket) / places) * 100:f2}% full.");
            }

            totalticket = totalkid + totalstandard + totalstudent;

            Console.WriteLine($"Total tickets: {totalticket}");
            Console.WriteLine($"{(totalstudent / totalticket) * 100:f2}% student tickets.");
            Console.WriteLine($"{(totalstandard / totalticket) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(totalkid / totalticket) * 100:f2}% kids tickets.");



        }
    }
}
