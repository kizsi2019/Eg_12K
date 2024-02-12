using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskola
{
    internal class Tanulok
    {
        public int Ev { get; private set; }
        public string Osztaly { get; private set; }
        public string Nev { get; private set; }

        public Tanulok(string sor)
        {
            string[] parts = sor.Split(';');
            Ev = int.Parse(parts[0]);
            Osztaly = parts[1];
            Nev = parts[2];

        }

        public string Azonosito
        {
            get
            {
                string azon = (Ev % 1000).ToString();
                azon += Osztaly;
                string[] nevek = Nev.ToLower().Split(' ');
                azon += nevek[0].Substring(0, 3);
                azon += nevek[1].Substring(0, 3);

                return azon;
            }
        }

        public int NevHossza
        {
            get
            {
                return Nev.Replace(" ", "").Length;
            }

        }
    }
    
}
