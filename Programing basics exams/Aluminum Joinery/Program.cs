using System;

namespace Aluminum_Joinery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countDograma = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string deliverly = Console.ReadLine();
            double sum = 0;
            if (type == "90X130")
            {
                sum = countDograma * 110;
                if (countDograma > 30 && countDograma <= 60)
                {
                    sum = sum - (sum * 5) / 100;
                }
                else if (countDograma > 60)
                {
                    sum = sum - (sum * 8) / 100;
                }
            }
            else if (type == "100X150")
            {
                sum = countDograma * 140;
                if (countDograma > 40 && countDograma <= 80)
                {
                    sum = sum - (sum * 6) / 100;
                }
                else if (countDograma > 80)
                {
                    sum = sum - (sum * 10) / 100;
                }
            }
            else if (type == "130X180")
            {
                sum = countDograma * 190;
                if (countDograma > 20 && countDograma <= 50)
                {
                    sum = sum - (sum * 7) / 100;
                }
                else if (countDograma > 50)
                {
                    sum = sum - (sum * 12) / 100;
                }
            }
            else if (type == "200X300")
            {
                sum = countDograma * 250;
                if (countDograma > 25 && countDograma <= 50)
                {
                    sum = sum - (sum * 9) / 100;
                }
                else if (countDograma > 50)
                {
                    sum = sum - (sum * 14) / 100;
                }
            }
            if (deliverly == "With delivery")
            {
                sum += 60;
            }
            if (countDograma >= 99)
            {
                sum = sum - (sum * 4) / 100;
            }
            if (countDograma < 10)
            {
                Console.WriteLine("Invalid order");
                return;
            }
            Console.WriteLine($"{sum:f2} BGN");
        }
    }
}
