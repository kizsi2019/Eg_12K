using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukkMaraton2019
{
    public class Versenyzo
    {
        public string Rajtszam {  get; set; }
        public string Kategoria { get; set; }
        public string Nev {  get; set; }
        public string Egyesulet { get; set; }
        public string Ido { get; set; }

        public Versenyzo(string line)
        {
            string[] temp = line.Split(';');

            Rajtszam = temp[0];
            Kategoria = temp[1];
            Nev = temp[2];
            Egyesulet = temp[3];
            Ido = temp[4];
        }

        public int Osszido()
        {
            string[] temp = Ido.Split(':');
            int ora = int.Parse(temp[0]);
            int perc = int.Parse(temp[1]);
            int mp = int.Parse(temp[2]);
            return (ora * 3600 + 60 * perc + mp);
        }
    }
}
