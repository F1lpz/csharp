using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight
{
    internal class pokemon
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public pokemon(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public int Attack()
        {
            Random rnd = new Random();
            return rnd.Next(40, 60);

        }

        public int Heal()
        {
            Random rnd = new Random();
            int healValue = rnd.Next(20, 71);
            Health += healValue;
            if (Health > 100) ;
            return healValue;
        }
    }
}

    

