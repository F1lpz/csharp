using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvicenie_LINQ
{
    internal class student
    {
        public string name { get; set; }
        public int age { get; set; }

        public student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
