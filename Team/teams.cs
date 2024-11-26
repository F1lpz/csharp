using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team
{
    internal class teams
    {

        private string name;
        private int numofteams;



        public teams(string name)
        {
            this.name = name;
            this.numofteams++;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int NumOfTeams
        {
            get { return numofteams; }
            set { if (value < 8)
                    Console.WriteLine("errororororororor");
            }
        }

        public static void getnumofteams()
        {
            Console.WriteLine("Number of teams is >");
        }
    }
}
