using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bukkmaraton2019
{
    internal class Versenyzo
    {
        public string Rajtszam { get; private set; }
        public string Kategoria { get; private set; }
        public string Nev{get; private set;}
    public string Egyesulet{get; private set;}
        public TimeSpan Ido{get; private set;}
        public string Tav{get; private set;}
        public string Noiversenyzo { get{ return Kategoria.Last() == 'n'; }  }
        public bool Tobbhatora { get { return Ido> new TimeSpan(6,0,0); } }
    
            public Versenyzo(string sor)
        {
            string[] a = sor.Split(";");
            Rajtszam = a[0];
            Kategoria = a[1];
            Nev = a[2];
            Egyesulet= a[3];
            int ora = int.Parse(a[4].Split(";")[0]);
            int perc = int.Parse(a[4].Split(";")[1]);
            int mas = int.Parse(a[4].Split(";")[2]);
            Ido = new TimeSpan(ora, perc, mas);
            Tav = new Versenytav(Rajtszam).Tav;
        }


    }

}
