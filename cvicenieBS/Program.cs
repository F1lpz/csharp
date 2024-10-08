using System;

namespace MyApp
{
    internal class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("write text:");
            string veta = Console.ReadLine();
            int pocetsamohlasok = spocitajsamohlasky(veta);
            Console.WriteLine("there are" +  pocetsamohlasok+ "in this text.");
        }


        public int spocitajsamohlasky(string text)
        {


            int pocet = 0;


            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'e')
                {
                    pocet++;
                }



                pocet++;
            }


            return pocet;
        }
    }
}
