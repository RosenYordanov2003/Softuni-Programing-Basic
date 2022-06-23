using System;

namespace Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int countsofproject = int.Parse(Console.ReadLine());
            var timeforproject = 3;
            var hoursneeded = countsofproject * timeforproject;
            Console.WriteLine("The architect {0} will need {1} hours to complete {2} project/s.", name, hoursneeded, countsofproject);
        }
    }
}
