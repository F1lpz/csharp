using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using static System.Formats.Asn1.AsnWriter;

namespace mesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> mesto = new List<string>();


            bool isend = false;
            while (!isend)
            {
                menu();
                var answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        foreach (var item in mesto)
                        {
                            Console.WriteLine(item);
                        }
                        break;


                    case "2":
                        Console.WriteLine("write name of civilian");
                        var newitemname = Console.ReadLine();
                        Console.WriteLine("add number of civilians");
                        var newitemcount = Console.ReadLine();
                        AddItem(mesto, newitemname, int.Parse(newitemcount));
                        break;

                }




            }
             static void AddItem(List<string> itemlist, string itemname, int itemcount)
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
                    Console.WriteLine($"civilian {itemname.ToUpper()} was added");
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




                static void menu()
                {
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.WriteLine("choose action:");
                    Console.WriteLine("1.show all civilians");
                    Console.WriteLine("2.add civilians to city");
                }






            }
        }
    }


