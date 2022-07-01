using System;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seats = int.Parse(Console.ReadLine());
            string comand = Console.ReadLine();
            int ticketsPruice = 5;
            double total = 0;
            double discount = 5;

            int people = 0;
            while (comand != "Movie time!")
            {
                people = int.Parse(comand);
                seats -= people;
                double sum = ticketsPruice * people;
                if (people % 3 == 0)
                {
                    sum = sum - discount;
                }
                total += sum;
                comand = Console.ReadLine();
                if (seats < 0)
                {
                    Console.WriteLine("The cinema is full.");
                    total -= sum;
                    break;
                }


            }
            if (comand == "Movie time!")
            {
                Console.WriteLine($"There are {seats} seats left in the cinema.");
                Console.WriteLine($"Cinema income - {total} lv.");
                return;
            }

            Console.WriteLine($"Cinema income - {total} lv.");
        }
    }
}
