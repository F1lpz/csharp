using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cvicenie_OOP
{
    public class vehicle
    {
        public string EvidencneCisloAuta { get; set; }
        public int RokVyroby { get; set; }  
        public bool JePlatnaSTK { get; set; }
        public double PriemernaSpotreba { get; set; }
        public char TypMotoru { get; set; }     //D - diesel  B - benzin  E - elektro

        public vehicle(string evidencecisloAuta, int rokVyroby, bool jePlatnaTK, double priemernaSpotreba, char typMotora)
        {
            EvidencneCisloAuta = evidencecisloAuta;
            RokVyroby = rokVyroby;
            JePlatnaSTK = JePlatnaSTK;
            PriemernaSpotreba = priemernaSpotreba;
            TypMotoru = typMotora;

        }
            public string vypisauta()
            {
                var informacie = $"SPZ:{EvidencneCisloAuta},{RokVyroby},{JePlatnaSTK}" + $"Spotreba:{PriemernaSpotreba},Motor:{TypMotoru}";
                return informacie;
            }
        public string vypisauta(bool plneinfo)
        {
            var informacie = $"SPZ:{EvidencneCisloAuta},{RokVyroby},{JePlatnaSTK}";
            if (plneinfo)
            {
                informacie += $"Spotreba:{PriemernaSpotreba},Motor:{TypMotoru}";
            }
            return informacie;
        }
        
    }
}




    

