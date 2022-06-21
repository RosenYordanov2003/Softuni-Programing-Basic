using System;

namespace Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double result = 0;
            if (operation == "+")
            {
                result = number1 + number2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} + {number2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} + {number2} = {result} - odd");
                }
            }
            else if (operation == "-")
            {
                result = number1 - number2;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} - {number2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} - {number2} = {result} - odd");
                }
            }
            else if (operation == "*")
            {
                result = number1 * number2;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} * {number2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} * {number2} = {result} - odd");
                }
            }

            else if (operation == "%")
            {
                if (number2 != 0)
                {

                    Console.WriteLine($"{number1} % {number2} = {number1 % number2}");
                }
                else { Console.WriteLine($"Cannot divide {number1} by zero"); }


            }
            else if (operation == "/")
            {
                if (number2 != 0) { Console.WriteLine($"{number1} / {number2} = {number1 * 1.0 / number2:F2}"); }
                else { Console.WriteLine($"Cannot divide {number1} by zero"); }
            }
        }
    }
}
