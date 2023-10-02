using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Szia uram!");
            Console.Beep(140, 2000);
            Console.Clear();
            Console.ReadKey();*/

            //0-t ír ki, mivel x int és a 4 is int
            /*int x = 3;
            Console.WriteLine(x / 4);

            //0,75 mert az x átkonvertálódik double típusra
            Console.WriteLine((double)x / 4);*/

            /*Console.WriteLine("Add meg a négyzet oldalált");
            int szam = Convert.ToInt32(Console.ReadLine());
            int ker = 4 * szam;
            int ter = szam * szam;
            Console.WriteLine("A négyzetnek a terület:" + ter);
            Console.WriteLine("A négyzetnek a kerülete:" + ker);
            Console.ReadKey(); */

            /*Console.WriteLine("Pénz: {0:C1}", 3148);
            Console.WriteLine("Százalék: {0:P3}", 0.123456);
            Console.WriteLine("Általános: {0:G}", 132354);
            Console.WriteLine("Exponenciális: {0:E}", 132354);
            Console.WriteLine("Hexa: {0:X}", 255);*/

            /*string nev = "World";
            string hello = $"Hello {nev}!";
            Console.WriteLine(hello);*/
            /*var ido = DateTime.Now;

            Console.WriteLine("{0:d}", ido);
            Console.WriteLine("{0:D}", ido);
            Console.WriteLine("{0:t}", ido);
            Console.WriteLine("{0:T}", ido);
            Console.WriteLine("{0:f}", ido);
            Console.WriteLine("{0:F}", ido);
            Console.WriteLine("{0:g}", ido);
            Console.WriteLine("{0:G}", ido);
            Console.WriteLine("{0:M}", ido);
            Console.WriteLine("{0:r}", ido);
            Console.WriteLine("{0:Y}", ido);
            Console.WriteLine("{0:yyyy-mm-dd, dddd tt hh:mm:ss}", ido);
            Console.ReadKey();*/


            /*var uiCulture = CultureInfo.CurrentUICulture;
            var currentCulture = CultureInfo.CurrentCulture;
            var angolCulture = CultureInfo.CreateSpecificCulture("en-US");

            double d = 1.2579;

            Console.WriteLine("uiCulture: {0}", uiCulture.Name);
            Console.WriteLine("currentCulture: {0}", currentCulture.Name);

            var current = string.Format(currentCulture, "{0}, {1}, {2:C}", d, DateTime.Now, 32580);
            var angol = string.Format(angolCulture, "{0}, {1}, {2:C}", d, DateTime.Now, 32580);
            Console.WriteLine(current);
            Console.WriteLine(angol);

            var angolFormat = Convert.ToDouble("3.14", angolCulture);
            Console.WriteLine(angolFormat);

            string teszt = "🐰";
            Console.WriteLine("A szoveg hossza: {0}", teszt.Length);

            var info = new StringInfo(teszt);
            Console.WriteLine("A szoveg valodi hossza: {0}", info.LengthInTextElements);*/

            /*double b = Math.Ceiling(1.12);
            Console.WriteLine(b);
            int a = Math.Max(2, 3);
            Console.WriteLine(a);
            double c = Math.Round(1.12345, 2);
            Console.WriteLine(c);
            Console.WriteLine(Math.PI);*/

            /*Console.WriteLine("add meg a kör sugarát");
            string bekert = Console.ReadLine();
            int szam = Convert.ToInt32(bekert);
            var ker = Math.PI * 2 * szam;
            var ter = szam * szam * Math.PI;
            var kerulet = Math.Round(ker, 2);
            var terulet = Math.Round(ter, 2);
            Console.WriteLine("A kör kerülete: " + kerulet);
            Console.WriteLine("A kör területe: " + terulet);*/


            /*Console.WriteLine("Menü program");
            Console.WriteLine("Opciók:");
            Console.WriteLine("A: Kis kávé, B: Nagy kávé");
            Console.WriteLine("C: Nem iszom semmit");
            Console.Write("Kérem válasszon!: ");*/
            /*var gomb = (char)Console.Read();

            if (gomb == 'A' || gomb == 'a')
            {
                Console.WriteLine("Kis kávét választott");
            }
            else if (gomb == 'B' || gomb == 'b')
            {
                Console.WriteLine("Nagy kávét választott");
            }
            else if (gomb == 'C' || gomb == 'c')
            {
                Console.WriteLine("Kár");
            }
            else
            {
                Console.WriteLine("Nem jó gombot nyomott!");*/

            /*Console.WriteLine("Menü program");
            Console.WriteLine("Opciók:");
            Console.WriteLine("A: Kis kávé, B: Nagy kávé");
            Console.WriteLine("C: Nem iszom semmit");
            Console.Write("Kérem válasszon!: ");
            var gomb = (char)Console.Read();

            switch (gomb)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("Kis kávét választott");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("Nagy kávét választott");
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine("Kár");
                    break;
                default:
                    Console.WriteLine("Nem jó gombot nyomott!");
                    break;
            }*/

            /*string szoveg = "valami szöveg";
            int szam = Convert.ToInt32(szoveg);
            Console.WriteLine(szam);
            Console.ReadKey();*/

            /*try
            {
                string szoveg = "valami szöveg";
                int szam = Convert.ToInt32(szoveg);
                Console.WriteLine(szam);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Valami hiba történt: {0}", ex.Message);
            }
            Console.WriteLine("Kettővel szorzó v. 1.0");
            Console.WriteLine("Adjon meg egy egész páros számot!");
            try
            {
                var bevitel = Console.ReadLine();
                int szam = Convert.ToInt32(bevitel);

                if ((szam % 2) != 0)
                {
                    throw new Exception("A szám nem páros");
                }
                Console.WriteLine($"A szorzás eredménye: {szam * 2}");

            }
            catch (Exception ex)
            {
                Console.WriteLine("HIBA történt");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program vége. Nyomjon egy gombot a kilépéshez");*/

            /*Console.WriteLine("add meg a negyzet oldalat");
                try
            {
                string bekert = Console.ReadLine();
                int szam = Convert.ToInt32(bekert);
                Console.WriteLine("a negyzet kerulete" + 4 * szam + ";");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("404: {0}", ex.Message);
            }*/

            /*Console.WriteLine("Goto példa. Kilépés: CTRL+C");
            eleje:
                Console.WriteLine("Add meg a neved");
                var nev = Console.ReadLine();
            Console.WriteLine($"Szia {nev}!");
                goto eleje;
            */

            /*for (int i = 0; i < 100; i+=8)
            {
                Console.WriteLine(i);
            }
            
            var gyumolcsok = new string[]
{
                "alma", "körte", "szilva"
};

            var bevitelek = new string[3];

            for (int i = 0; i < bevitelek.Length; i++)
            {
                Console.WriteLine("{0}. bevitel: ", i);
                bevitelek[i] = Console.ReadLine();
            }

            foreach (var gyumolcs in gyumolcsok)
            {
                Console.WriteLine(gyumolcs);
            }
            foreach (var bevitel in bevitelek)
            {
                Console.WriteLine(bevitel);
            }*/
            //tömb elemeinek meghatározása
            //minden sor külön zárójelet igényel
            var tomb2d = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine("Bejárás for ciklusokkal");
            //A length tulajdonság itt nem használható
            //mivel a tömb 2d kiterjedésű. 
            for (int i = 0; i < tomb2d.GetLength(0); i++)
            {
                for (int j = 0; j < tomb2d.GetLength(1); j++)
                {
                    Console.Write("{0} ", tomb2d[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Bejárás foreach ciklusokkal");
            foreach (var elem in tomb2d)
            {
                Console.Write("{0} ", elem);
            }
            Console.ReadLine();

            Console.ReadKey();

        }
    }
}
