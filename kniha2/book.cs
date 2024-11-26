using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kniha2
{
    internal class book
    {

        private string name;
        private int numofpages;




        public book(string name, int numofpages)
        {
            this.name = name;
            this.numofpages = numofpages;
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int NumOfPages
        {
            get { return numofpages; }
            set
            {
                if (value < 9)
                    numofpages = value;
                else
                    Console.WriteLine("Error");
            }

        }
    }
}
