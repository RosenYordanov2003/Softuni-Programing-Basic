using System;

namespace New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeflower = Console.ReadLine();
            double countofflower = int.Parse(Console.ReadLine());
            double money = int.Parse(Console.ReadLine());
            double price = 0;
            double priceofsrose = 5;
            double priceofdaliq = 3.80;
            double priceoflale = 2.80;
            int priceofnarcis = 3;
            double priceofgladiola = 2.50;

            switch (typeflower)
            {

                case "Roses":
                    if (countofflower > 80)
                    {
                        price = countofflower * priceofsrose - (countofflower * priceofsrose * 0.10);
                    }
                    else
                    {
                        price = countofflower * priceofsrose;
                    }


                    break;
                case "Dahlias":
                    if (countofflower > 90)
                    {
                        price = countofflower * priceofdaliq - (countofflower * priceofdaliq * 0.15);
                    }
                    else
                    {
                        price = countofflower * priceofdaliq;
                    }

                    break;
                case "Tulips":
                    if (countofflower > 80)
                    {
                        price = countofflower * priceoflale - (countofflower * priceoflale * 0.15);
                    }
                    else
                    {
                        price = countofflower * priceoflale;
                    }

                    break;
                case "Narcissus":
                    if (countofflower < 120)
                    {
                        price = countofflower * priceofnarcis;
                        price = price + (price * 0.15);
                    }
                    else
                    {
                        price = countofflower * priceofnarcis;
                    }

                    break;
                case "Gladiolus":
                    if (countofflower < 80)
                    {
                        price = countofflower * priceofgladiola;
                        price = price + (price * 0.20);

                    }
                    else
                    {
                        price = countofflower * priceofgladiola;
                    }


                    break;
                default:
                    break;

            }
            if (money >= price)
            {
                double leftmoney = money - price;
                Console.WriteLine($"Hey, you have a great garden with {countofflower} {typeflower} and { leftmoney:F2} leva left.");
            }
            else
            {
                double moneyneed = Math.Abs(money - price);
                Console.WriteLine($"Not enough money, you need {moneyneed:F2} leva more.");
            }

        }
    }
}
