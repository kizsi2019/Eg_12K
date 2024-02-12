using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskola
{
    internal class Tanuló
    {
        public int Kezdés { get; private set; }
        public char Osztály { get; private set; }
        public string Név { get; private set; }
        public string KezdésOsztály => $"{Kezdés} {Osztály}";

        public int NévHossza
        {
            get
            {
                int szóközDb = 0;
                foreach (var i in Név)
                {
                    if (i == ' ') szóközDb++;
                }
                return Név.Length - szóközDb;
            }
        }

        // 6. feladathoz jellemző definiálása:
        public string Azonosító
        {
            get
            {
                char évfolyamUtolsóKaraktere = Kezdés.ToString()[3];
                string vnév3 = Név.Substring(0, 3).ToLower();
                string knév3 = Név.Split()[1].Substring(0, 3).ToLower();
                return $"{évfolyamUtolsóKaraktere}{Osztály}{vnév3}{knév3}";
            }
        }

        public Tanuló(string sor)
        {
            string[] m = sor.Split(';');
            Kezdés = int.Parse(m[0]);
            Osztály = char.Parse(m[1]);
            Név = m[2];
        }
    }
}
