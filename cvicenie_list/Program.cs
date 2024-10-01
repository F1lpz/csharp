using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* int[] numbers = new int[5];
            //10 15 20 25 45 
            numbers[0] = 10;
            numbers[1] = 15;
            numbers[2] = 20;
            numbers[3] = 25;
            numbers[4] = 40;
            Console.WriteLine(numbers[2]+ numbers[4]);*/



            List<string> listname = new List<string>();

            listname.Add("filip");
            listname.Add("olino");
            listname.Add("brano");
            listname.Add("mato");
            listname.Add("jozo");
            listname.Add("igor");

            Console.WriteLine(listname[0]);
            Console.WriteLine(listname[1]);
            Console.WriteLine(listname[2]);
            Console.WriteLine(listname[3]);
            Console.WriteLine(listname[4]);
            Console.WriteLine(listname[5]);
        }
    }
}


