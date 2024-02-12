using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
    class FogadasiFordulo
    {
        public int Év { get; private set; }
        public int Hét { get; private set; }
        public int Forduló { get; private set; }
        public int TelitalálatDarab { get; private set; }
        public int TelitalálatNyereméy { get; private set; }
        public string Eredmények { get; private set; }

        public int NyereményÖsszeg => TelitalálatDarab * TelitalálatNyereméy;

        public FogadasiFordulo(string sor)
        {
            string[] m = sor.Split(';');
            Év = int.Parse(m[0]);
            Hét = int.Parse(m[1]);
            Forduló = int.Parse(m[2]);
            TelitalálatDarab = int.Parse(m[3]);
            TelitalálatNyereméy = int.Parse(m[4]);
            Eredmények = m[5];
        }

        public void EredménytKiír()
        {
            Console.WriteLine($"\tÉv: {Év}");
            Console.WriteLine($"\tHét: {Hét}.");
            Console.WriteLine($"\tForduló: {Forduló}.");
            Console.WriteLine($"\tTelitalálat: {TelitalálatDarab} db");
            Console.WriteLine($"\tNyeremény: {TelitalálatNyereméy} Ft");
            Console.WriteLine($"\tEredmények: {Eredmények}");
        }
    }
}
