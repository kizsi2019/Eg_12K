using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskola
{
    internal class Import
    {
        public int ev {  get; private set; }
        public char jel { get; private set; }
        public string nev { get; private set; }

        public Import(string sor)
        {
            string[] line = sor.Split(';');
            ev = int.Parse(line[0]);
            jel = char.Parse(line[1]);
            nev = line[2];
        }

        public int NevHossza
        {
            get
            {
                return nev.Replace(" ", "").Length;
            }

        }
        public string Azonosito
        {
            get
            {
                string azon = (ev % 1000).ToString();
                azon += jel;
                string[] nevek = nev.ToLower().Split(' ');
                azon += nevek[0].Substring(0, 3);
                azon += nevek[1].Substring(0, 3);

                return azon;
            }
        }

    }
}
