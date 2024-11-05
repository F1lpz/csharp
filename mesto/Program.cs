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

            doctor doc = new doctor(name: "igor",age: 34);
            programator prog = new programator (name: "laco",age: 25 , programlanguage: "C++");
            seniorprogramator seprog = new seniorprogramator(name: "jozo", age: 41 , numberofprojects:15 , programlanguage: "python");


            






        }
    }
}



