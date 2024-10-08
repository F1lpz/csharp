using System;
using System.CodeDom.Compiler;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int generatednum = rnd.Next(100);

            Console.WriteLine("guess the number");

            while (0 < 5)
            {
                
                string text = Console.ReadLine();
                int attempts = 5;
                int num = int.Parse(text);





                {


                    if (generatednum == num)
                    {
                        Console.WriteLine("you got it");
                        break;
                    }

                    if (generatednum < num)
                    {
                        Console.WriteLine("its smaller nuh uh");
                    }

                    if (generatednum > num)
                    {
                        Console.WriteLine("its bigger duh");
                    }

                    Console.WriteLine("attempts remaining:");


                    
                }








            }
        }
    }
}

        