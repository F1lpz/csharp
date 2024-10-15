namespace cvicenie_OPP_hra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            player zemepan = new player("jozko" ,75,900,150);
            player assasin = new player("nigi", 100, 1500, 320);

            while (true)
            {
                zemepan.damagedplayer(assasin);
                assasin.damagedplayer(zemepan);

                int hp = 100;
                if (hp < 0)
                {
                    break;
                }
                    
                    
            }
            
        }
    }
}