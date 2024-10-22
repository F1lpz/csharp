using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace project1
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("vypocitaj obdlznik.");
            Console.WriteLine("zadaj x:");
            

            string vstup = Console.ReadLine();
            int x = int.Parse(vstup);

            string vystup = Console.ReadLine();
            int y = int.Parse(vystup);

            property rob = new property(x, y);
            int obsah = rob.obsah();
            Console.WriteLine(obsah);


            property rob = new property(rob.x, rob.y);
            int obsah1 = rob.obsah1();
            Console.WriteLine(obsah1);
                

            







        }
    }
}