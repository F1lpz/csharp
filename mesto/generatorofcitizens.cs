using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesto
{
    internal class generatorofcitizens
    {
        private static string[] mena = { "Igor", "Anna", "Peter", "Jana", "Martin", "Lucia", "Tomáš", "Eva", "Michal", "Zuzana", "Marek", "Katarína", "Andrej", "Lenka", "Patrik", "Monika", "Filip", "Veronika", "Richard", "Simona", "Róbert", "Mária", "Jakub", "Barbora", "Adam", "Dominika", "Lukáš", "Daniela", "Vladimír", "Nikola" };

        private static string[] programlanguages = { "python", "c+", "javascript", "csharp", "java" }; 
        public static citizen generatecitizen()
        {
            Random r = new Random();
            int position = r.Next(mena.Length);
            string name = mena[position];
            int age = r.Next(15, 116);
            citizen citizen = new citizen(name, age);
            return citizen;


            

        }
        public static programator generateprogramator()
        {
            Random r = new Random();
            int position = r.Next(mena.Length);
            string name = mena[position];
            int age = r.Next(15, 116);
            int position1 = r.Next(programlanguages.Length);
            string programlanguage = programlanguages[position1];
            citizen citizen1 = new citizen(name, age, programlanguage);
        }


    }


}
