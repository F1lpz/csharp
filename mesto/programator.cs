using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesto
{
    internal class programator
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public programator(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void displayinfo()
        {
            Console.WriteLine("programator named " + Name + "" + Age + "" + "that works on pc");
        }


    }

}
