using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using static System.Formats.Asn1.AsnWriter;

namespace mesto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            city city1 = new city("bratislava");
            city city2 = new city("zilina");

            citizen citizen1 = new citizen("jozo", 20);
            city1.addcitizen(citizen1);
            city1.addcitizen(new citizen("matej", 25));
            city1.addcitizen(new citizen("jakub", 16));
            city1.addcitizen(new citizen("erika", 37));
            city1.addcitizen(new citizen("laco", 45));

            city2.addcitizen(new citizen("marek", 36));
            city2.addcitizen(new citizen("lucia", 65));
            city2.addcitizen(new citizen("pavlina", 11));
            city2.addcitizen(new citizen("erik", 23));

            city1.writecitizens();
            city2.writecitizens();






        }
    }
}



