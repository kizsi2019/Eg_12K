using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskola
{
    class Tanulok
    {
        public int Ev { get; private set; }
        public string Osztaly { get; private set; }
        public string Nev { get; private set; }

        public Tanulok(string sor)
        {
            string[] adatok = sor.Split(';');
            Ev = int.Parse(adatok[0]);
            Osztaly = adatok[1];
            Nev = adatok[2];
        }

        public int nevhossz
        {
            get
            {
                return Nev.Replace(" ", " ").Length;
            }
        }

        public string Azonosíto
        {
            get
            {
                string azonosit = (Ev % 1000).ToString();
                azonosit = Osztaly;
                string[] nevek = Nev.ToLower().Split(' ');
                azonosit += nevek[0].Substring(0, 3);
                azonosit += nevek[1].Substring(0, 3);

                return azonosit;
            }
        }
    }
}
