using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesto
{
    public class city
    {
        public string name1  { get; set; }
        public List<citizen> citizens { get; set; }

        public city(string name1)
        {
            this.name1 = name1;
            citizens = new List<citizen>();
        }

        public void addcitizen(citizen citizen)
        {
            citizens.Add(citizen);
        }


        public void writecitizens()
        {
            Console.WriteLine("citizens of" + name1+":");
            foreach (var citizen in citizens)
            {
                citizen.info();
            }
        }

    }
}
