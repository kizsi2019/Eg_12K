using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
    internal class FogadasiFordulo
    {
        public int Év { get; private set; }
        public int Hét { get; private set; }
        public int Fordulo { get; private set; }
        public int T13p1 { get; private set; }
        public int Ny13p1 { get; private set; }
        public string Eredmenyek { get; private set; }

        public int NyereményÖsszeg => T13p1 * Ny13p1;

        public FogadasiFordulo(string sor)
        {
            string[] m = sor.Split(';');
            Év = int.Parse(m[0]);
            Hét = int.Parse(m[1]);
            Fordulo = int.Parse(m[2]);
            T13p1 = int.Parse(m[3]);
            Ny13p1 = int.Parse(m[4]);
            Eredmenyek = m[5];
        }

        public void EredménytKiír()
        {
            Console.WriteLine($"\tÉv: {Év}");
            Console.WriteLine($"\tHét: {Hét}.");
            Console.WriteLine($"\tForduló: {Fordulo}.");
            Console.WriteLine($"\tTelitalálat: {T13p1} db");
            Console.WriteLine($"\tNyeremény: {Ny13p1} Ft");
            Console.WriteLine($"\tEredmények: {Eredmenyek}");
        }
    }


}
