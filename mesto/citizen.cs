using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesto
{
    public class citizen
    {
        public string name { get; set; }
        public int age { get; set; }

        public citizen(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void info()
        {
            Console.WriteLine("meno" + name + "vek" + age);
        }
    }
}
