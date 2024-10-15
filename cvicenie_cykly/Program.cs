using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listname = new List<string>();
            {
                listname.Add("FILIP");
                listname.Add("OLINO");
                listname.Add("BRANO");
                listname.Add("MATO");
                listname.Add("JOZO");
                listname.Add("IGOR");

                int counter = 69;
                foreach (string name in listname)
                {
                Console.WriteLine(name);
                    break;
                }
            }
        }
    }
}





