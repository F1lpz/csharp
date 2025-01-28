using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vinimky
{
    internal class student
    {
        public int id {  get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string schoolclassname { get; set; }
        public string gender { get; set; }
        public string surname { get; set; }
        public List<int> grades { get; set; }

        public student(string name, string surname, int age, string schoolclassname)
        {
            this.name = name;
            this.age = age;
            this.schoolclassname = schoolclassname;
            this.surname = surname;
        }



    }
}
