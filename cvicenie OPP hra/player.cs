using System;
using System.Collections.Generic;
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


        public player(string name, int hp, int mana, int attackpower)
        {
            this.name = name;
            this.hp = hp;
            this.mana = mana;
            this.attackpower = attackpower;
        }
        public void damagedplayer(player player)
        {
            int hpofenemy = player.hp;
            int attackofcurrentplayer = this.attackpower;
            int hpofenemyafterfight = hpofenemy - attackofcurrentplayer;
            player.hp = hpofenemyafterfight;
        }


            
        }
    }

