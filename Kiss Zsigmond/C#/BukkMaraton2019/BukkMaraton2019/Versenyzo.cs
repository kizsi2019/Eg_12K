using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukkMaraton2019
{
    internal class Versenyzo
    {
        public string Rajtszam {  get; private set; }
        public string Kategoria { get; private set; }
        public string Nev { get; private set; }
        public string Egyesulet { get; private set; }
        public TimeSpan Ido {  get; private set; }
        public string Tav { get; private set; }
        public bool NoiVersenyzo {
            get
            {
                return Kategoria.Last() == 'n';
            }
            }
        public bool TobbMintHat
        {
            get
            {
                return Ido > new TimeSpan(6, 0, 0);
            }
        }


        public Versenyzo(string sor)
        {
            string[] m = sor.Split(';');
            Rajtszam = m[0];
            Kategoria = m[1];
            Nev = m[2];
            Egyesulet = m[3];
            int ora = int.Parse(m[4].Split(':')[0]) ;
            int perc = int.Parse(m[4].Split(':')[1]);
            int mp = int.Parse(m[4].Split(':')[2]);
            Ido = new TimeSpan(ora, perc, mp);
            Tav = new Versenytav(Rajtszam).Tav;
        }

    }

   
}
