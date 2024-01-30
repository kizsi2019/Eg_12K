using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
    internal class EredmenyElemzo
    {
        private string Eredmenyek;

        public string ev {  get; private set; }
        public string het { get; private set; }
        public int fordulo { get; private set; }
        public int t13p1 { get; private set; }
        public int ny13p1 { get; private set; }
        public string eredmeny { get; private set; }

        public EredmenyElemzo(string sor)
        {
            string[] s = sor.Split(';'); 
            ev= s[0];
            het = s[1];
            fordulo = Convert.ToInt32(s[2]);
            t13p1 = Convert.ToInt32(s[3]);
            ny13p1 = Convert.ToInt32(s[4]);
            eredmeny = s[5];
        }

        private int DontetlenekSzama
        {
            get
            {
                return Megszamol('X');
            }
        }

        private int Megszamol(char kimenet)
        {
            int darab = 0;
            foreach (var i in Eredmenyek)
            {
                if (i == kimenet) darab++;
            }
            return darab;
        }

        public bool NemvoltDontetlenMerkozes
        {
            get
            {
                return DontetlenekSzama == 0;
            }
        }

        

        
    }
}
