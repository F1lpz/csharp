using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesto
{
    public class programator : citizen
    {


        public string programlanguage;
        public programator(string name, int age, string programlanguage) : base(name, age)
        {
            this.programlanguage = programlanguage;
        }
       

        public override void info()
        {
            Console.WriteLine("programator named " + name + "" + age + "" + "and he uses");
        }


    }

}
