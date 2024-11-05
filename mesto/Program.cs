using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using static System.Formats.Asn1.AsnWriter;

namespace mesto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            city bratislava = new city("bratislava");


            citizen o = generatorofcitizens.generatecitizen();

            bratislava.addcitizen(o);

            bratislava.writecitizens();



            for (int i = 0; i < 31; i++)
            {
                citizen o = generatorofcitizens.generatecitizen();
                bratislava.addcitizen(o);
            }
            bratislava.writecitizens();
            bratislava.generateproglan();
        }
    }
}



