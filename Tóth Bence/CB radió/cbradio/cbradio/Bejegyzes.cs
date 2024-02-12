using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbradio
{
    internal class Bejegyzes
    {
        public int KezdOra { get; private set; }
        public int KezdPerc { get; private set; }
        public int AdasDb { get; private set; }
        public string Nev { get; private set; }
        public Bejegyzes(string sor)
        {
            string[] m = sor.Split(';');
            KezdOra = int.Parse(m[0]);
            KezdPerc = int.Parse(m[1]);
            AdasDb = int.Parse(m[2]);
            Nev = m[3];
        }

        // 6. feladat
        private int Percre(int ora, int perc) => ora * 60 + perc;

        public int Kezdes => Percre(KezdOra, KezdPerc);
    }
}
