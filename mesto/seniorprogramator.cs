using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesto
{
    public class seniorprogramator : programator
    {
        public int numberofprojects;

        public seniorprogramator(string name, int age, string programlanguage, int numberofprojects) : base(name,age,programlanguage)
        {
            this.numberofprojects = numberofprojects;
        }

        public new void displayinfo()
        {
            Console.WriteLine(name + "" + age + "programs in:" + programlanguage + "and has:" + numberofprojects + "projects");
        }
    }

}
