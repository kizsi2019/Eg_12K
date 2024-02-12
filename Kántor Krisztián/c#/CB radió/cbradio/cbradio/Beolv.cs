using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbradio
{
    internal class Beolv
    {
        public int ora {  get; private set; }
        public int perc { get; private set; }
        public int db { get; private set; }
        public string nev { get; private set; }

        public Beolv(string sor)
        {
            string[] s=sor.Split(';');
            ora = Convert.ToInt32( s[0]);
            perc = Convert.ToInt32(s[1]);
            db = Convert.ToInt32(s[2]);
            nev = s[3];
        }


        //6
        private int AtszamolPercre(int Ora, int Perc)
        {
            return Ora * 60 + Perc;
        }


        //7
        public int Kezdes()
        {
            return AtszamolPercre(ora, perc);
        }
    }
}
