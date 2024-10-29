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

            
            
            city1.addcitizen(new citizen("erika", 37));
            city1.addcitizen(new citizen("laco", 45));
            

            city2.addcitizen(new citizen("marek", 36));
            city2.addcitizen(new citizen("lucia", 65));
            

            city1.writecitizens();
            city2.writecitizens();


            






        }
    }
}



