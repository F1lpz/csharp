using cvicenie_OPP_hra;
using System.Runtime.CompilerServices;

namespace Cvi4enie_OOP_Hra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            player player = new player();
            {
                player.name = "B";
                player.hp = 100;
                player.mana = 8;
                player.attackpower = 6;
            }
            player player2 = new player();
            {
                player2.name = "H";
                player2.hp = 100;
                player2.mana = 15;
                player2.attackpower = 3;
            }
            
            
           

            int HP = 100;
            while (player.hp >= 0 && player2.hp > 0)
            {
                Thread.Sleep(700);
                Console.WriteLine("player hp:" + player.hp);
                Console.WriteLine("player2 hp:" + player2.hp);
                player.damagedplayer(player2);
                player2.damagedplayer(player);

                if (player.hp <= 20)
                {
                    bool washealed = player.heal();

                    if (washealed)
                    {
                        Console.WriteLine("player bol uzdraveny");
                    }
                    else
                    {
                        Console.WriteLine("player nebol uzdraveny");
                    }

                }
                if (player2.hp <= 20)
                {
                    bool washealed = player.heal();

                    if (washealed)
                    {
                        Console.WriteLine("player2 bol uzdraveny");
                    }
                    else
                    {
                        Console.WriteLine("player2 nebol uzdraveny");
                    }

                }


                if (player.hp <= 0)
                {
                    Console.WriteLine("Player1 vyhral");
                }
                else if (player2.hp <= 0)
                {
                    Console.WriteLine("Player2 vyhral");
                }

                player.refilmana(10);
                Random random = new Random();
                int randomnumber = random.Next(0, 100);
                if (randomnumber <= 5) ;
                {
                    player.refilmana(10);
                    Console.WriteLine("mana bola doplnena.");

                }
            }




            }
        }
    }
