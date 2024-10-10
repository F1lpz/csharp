using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> store = new List<string>();



            bool isEnd = false;
            while (!isEnd)
            {
                PrintMenu();
                var answer = Console.ReadLine();


                switch (answer)
                {
                    case "1":
                        foreach (var item in store)
                        {
                            Console.WriteLine(item);
                        }
                        break;


                    case "2":
                        Console.WriteLine("zadajte meno noveho predmetu");
                        var newitemname = Console.ReadLine();
                        Console.WriteLine("zadajte kolko kusov noveho predmetu");
                        var newitemcount = Console.ReadLine();
                        AddItem(store, newitemname, int.Parse(newitemcount));
                        break;

                    case "4":
                        isEnd = true;
                        break;
                        
                        default:
                        Console.WriteLine("nespravna akcia");
                        break;
                       



                }
            }
           







        }

        public static void AddItem(List<string> itemlist, string itemname, int itemcount)
        {

            string foundeditem = null;
            foreach (var item in itemlist)
            {
                if (item.Contains(item))
                {
                    foundeditem = item;
                }
            }

            if (foundeditem == null)
            {
                var newcreateditem = $"{itemname} || {itemcount}";
                itemlist.Add(newcreateditem);
                Console.WriteLine($"predmet {itemname.ToUpper()} bol pridany");
            }
            else
            {
                var splitteditem = foundeditem.Split("||");
                var foundeditemname = splitteditem[0];
                var foundeditemcount = int.Parse(splitteditem[1]);
                var newitemcount = foundeditemcount + itemcount;

                var indexofitems = foundeditem.IndexOf(foundeditem);
                itemlist[indexofitems] = $"{itemname}||{newitemcount}";
                Console.WriteLine($"predmet {itemname.ToUpper()} bol aktualizovany");
            }

            
        }




        public static void PrintMenu()
        {
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("1. vypis polozku");
            Console.WriteLine("2. pridavanie polozky");
            Console.WriteLine("4. Exit");
            Console.Write("vyber akciu");


        }


    }
}