using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbradio
{
    public class Bejegyzes
    {
        public int Ora { get; set; }
        public int Perc { get; set; }
        public int AdasDb { get; set; }
        public string Nev { get; set; }

        public Bejegyzes(string line)
        {
            string[] temp = line.Split(';');
            Ora = Convert.ToInt32(temp[0]);
            Perc = Convert.ToInt32(temp[1]);
            AdasDb = Convert.ToInt32(temp[2]);
            Nev = temp[3];
        }
    }
}
