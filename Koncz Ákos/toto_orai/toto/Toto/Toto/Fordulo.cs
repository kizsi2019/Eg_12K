using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
    internal class Fordulo
    {
        public int ev { get; set; }
        public int het { get; set; }
        public int fordulo { get; set; }
        public int talalatDb { get; set; }
        public int talalatNyeremeny { get; set; }
        public string eredmeny { get; set; }

        public Fordulo(string sor)
        {
            string[] s = sor.Split(';');
            ev = int.Parse(s[0]);
            het = int.Parse(s[1]);
            fordulo = int.Parse(s[2]);
            talalatDb = int.Parse(s[3]);
            talalatNyeremeny = int.Parse(s[4]);
            eredmeny = s[5];
        }

        public void Kiir()
        {
            Console.WriteLine($"\t Év: {ev}");
            Console.WriteLine($"\t Hét: {het}.");
            Console.WriteLine($"\t Forduló: {fordulo}.");
            Console.WriteLine($"\t Telitalálat: {talalatDb} db");
            Console.WriteLine($"\t Nyeremény: {talalatNyeremeny} Ft");
            Console.WriteLine($"\t Eredmények: {eredmeny}");
        }
    }
}
