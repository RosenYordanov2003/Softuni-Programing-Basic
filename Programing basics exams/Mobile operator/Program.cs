using System;

namespace Mobile_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lenght = Console.ReadLine();
            string type = Console.ReadLine();
            string mobileInternet = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());
            double tax = 0;
            double price = 0;
            double mobileInternetPrice = 0;
            double total = 0;

            if (lenght == "one")
            {
                if (type == "Small")
                {
                    price = 9.98 * months;
                    tax = 9.98;
                }
                else if (type == "Middle")
                {
                    price = 18.99 * months;
                    tax = 18.99;
                }
                else if (type == "Large")
                {
                    price = 25.98 * months;
                    tax = 25.98;
                }
                else if (type == "ExtraLarge")
                {
                    price = 35.99 * months;
                    tax = 35.99;
                }
            }
            else if (lenght == "two")
            {
                if (type == "Small")
                {
                    price = 8.58 * months;
                    tax = 8.58;
                }
                else if (type == "Middle")
                {
                    price = 17.09 * months;
                    tax = 17.09;
                }
                else if (type == "Large")
                {
                    price = 23.59 * months;
                    tax = 23.59;
                }
                else if (type == "ExtraLarge")
                {
                    price = 31.79 * months;
                    tax = 31.79;
                }
                price = price - (price * 3.75) / 100;

            }
            if (mobileInternet == "yes" && lenght == "two")
            {
                if (tax <= 10)
                {
                    mobileInternetPrice = 5.50 * months;
                }
                else if (tax <= 30)
                {
                    mobileInternetPrice = 4.35 * months;
                }
                else if (tax > 30)
                {
                    mobileInternetPrice = 3.85 * months;
                }
                mobileInternetPrice = mobileInternetPrice - (mobileInternetPrice * 3.75) / 100;
            }
            else if (mobileInternet == "yes" && lenght == "one")
            {
                if (tax <= 10)
                {
                    mobileInternetPrice = 5.50 * months;
                }
                else if (tax <= 30)
                {
                    mobileInternetPrice = 4.35 * months;
                }
                else if (tax > 30)
                {
                    mobileInternetPrice = 3.85 * months;
                }
            }
            total = price + mobileInternetPrice;
            Console.WriteLine($"{total:f2} lv.");
        }
    }
}
