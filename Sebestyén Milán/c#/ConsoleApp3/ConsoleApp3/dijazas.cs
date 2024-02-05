using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Dijazott
    {
        public int ev { get; private set; }
        public string nev { get; private set; }
        public string szuleteshalal { get; private set; }
        public string orszag { get; private set; }

        public Dijazott(string sor)
        {
            string[] a = sor.Split(';');
            ev = int.Parse(a[0]);
            nev = a[1];
            szuleteshalal = a[2];
            orszag = a[3];

        }
    }
}
