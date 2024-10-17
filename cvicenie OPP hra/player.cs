using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvicenie_OPP_hra
{
    internal class player
    {

        public string name { get; set; }
        public int hp { get; set; }
        public int mana { get; set; }
        public int attackpower { get; set; }

        public int critchange { get; set; }
        public player()
        {
        }

        public player(string name, int hp, int mana, int attackpower)
        {
            this.name = name;
            this.hp = hp;
            this.mana = mana;
            this.attackpower = attackpower;
        }
        public void damagedplayer(player player)
        {

            int damagemultiplier = 1;

            Random random = new Random();
            int randomnumber = random.Next(0, 100);
            if (randomnumber <= this.critchange)
            {
                damagemultiplier = 2;
                Console.WriteLine(this.name + "dal criticky zasah");
            }






            int hpofenemy = player.hp;
            int attackofcurrentplayer = this.attackpower;
            int hpofenemyafterfight = hpofenemy - attackofcurrentplayer;
            player.hp = hpofenemyafterfight;
        }

        public bool heal()
        {

            if (this.mana > 0)
            {
                int hpofplayer = this.hp;
                int manaofplayer = this.mana;
                int hpofplayerafterheal = hpofplayer + manaofplayer;
                this.mana = 0;
                this.hp = hpofplayerafterheal;
                return true;
            }
            else
            {
                return false;
            }
            
            
            


        }
        
        public void refilmana(int newmana)
        {
            this.mana = newmana;
            Random random = new Random();
            int randomnumberv= random.Next(0, 100);
            if (randomnumberv <= this.mana)
            {
                Console.WriteLine(this.mana + "many bolo doplnene");
            }
        }
    }
}

