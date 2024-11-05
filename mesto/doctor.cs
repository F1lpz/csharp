using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesto
{
    public class doctor : citizen
    {
        


        public doctor (string name, int age) : base (name, age)
        {

        }
        public new void displayinfo()
        {
            Console.WriteLine("doctor named " + "" + name + "" + age + "" + "that heals ppl");
        }
    }
    
}
