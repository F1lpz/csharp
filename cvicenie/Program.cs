using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            spocitajsamohlasky();
        }


        public static void spocitajsamohlasky()
        {
            Console.WriteLine("napis text");

            string napistext = Console.ReadLine();
            Console.WriteLine(napistext.Length);
        }
    }
}

