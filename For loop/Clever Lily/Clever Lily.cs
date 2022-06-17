using System;

namespace Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ages = int.Parse(Console.ReadLine());
            double washingmachine = double.Parse(Console.ReadLine());
            int pricetoy = int.Parse(Console.ReadLine());
            int toys = 0;
            int money = 10;
            double savedmoney = 0;
            int totaltoyprice = 0;
            double totalsavedmoney = 0;
            for (int yearsnow = 1; yearsnow <= ages; yearsnow++)
            {
                if (yearsnow % 2 == 0)
                {

                    savedmoney += (money - 1);
                    money += 10;
                }
                else
                {
                    toys += 1;
                    totaltoyprice = toys * pricetoy;
                }
                totalsavedmoney = savedmoney + totaltoyprice;


            }
            double leftmoney = 0;
            double moneyneed = 0;
            if (totalsavedmoney >= washingmachine)
            {
                leftmoney = totalsavedmoney - washingmachine;
                Console.WriteLine($"Yes! {leftmoney:f2}");
            }
            else
            {
                moneyneed = Math.Abs(totalsavedmoney - washingmachine);
                Console.WriteLine($"No! {moneyneed:f2}");
            }
        }
    }
}
