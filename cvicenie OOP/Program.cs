using cvicenie_OOP;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            vehicle skodafabia = new vehicle("KMN123EE" ,2003,true,7.5,'D');

            

            vehicle toyota = new vehicle("ABC565TT" ,1996,false,5,'D');
           
           Console.WriteLine(toyota.vypisauta(false));
           Console.WriteLine(toyota.vypisauta(true));

            List<vehicle> list = new List<vehicle>();

            list.Add(skodafabia);












        }
    }
}