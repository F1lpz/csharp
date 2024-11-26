using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesto
{
    public class citizen
    {

        protected string Name;
        protected int Age;

        public string Name1
        {
            get { return Name; }
            set { Name = value; }
        }
        public string name { get; set; }
        public int age { get; set; }
        private string programlanguage { get; set; }

        public citizen(string name, int age, string programlanguage)
        {
            this.name = name;
            this.age = age;
            this.programlanguage = programlanguage;
        }

        public virtual void info()
        {
            Console.WriteLine("meno:" + name + "vek:" + age);
           
        }
    }
}
