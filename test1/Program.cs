
using System;

namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {

            double num1 = 12;
            double num2 = 11;
            Console.WriteLine("zadaj operator");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    if
                        {
                        operation = 0; break;
                    }
                    break;
                default:
                    Console.WriteLine("zly operator");
                    break;
            }
        }
    }
}

