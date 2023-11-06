using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Beep()

            //Console.Write("Add meg egy oldalát a négyzetnek: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int k = 4 * a;
            //int t = a * a;
            //Console.WriteLine("Pénz: {0:C1}", 3148);
            //Console.WriteLine("Százalék: {0:P3}", 0.123456);
            //Console.WriteLine("Általános: {0:G}", 132354);
            //Console.WriteLine("Exponenciális: {0:E}", 132354);
            //Console.WriteLine("Hexa: {0:X}", 255);

            //string world = "world";
            //string hello = $"Hello {world}!";
            //Console.WriteLine(hello);

            //DateTime dateTime = DateTime.Now;

            //Console.WriteLine(dateTime.ToString());

            //var ido = DateTime.Now;

            //Console.WriteLine("{0:d}", ido);
            //Console.WriteLine("{0:D}", ido);
            //Console.WriteLine("{0:t}", ido);
            //Console.WriteLine("{0:T}", ido);
            //Console.WriteLine("{0:f}", ido);
            //Console.WriteLine("{0:F}", ido);
            //Console.WriteLine("{0:g}", ido);
            //Console.WriteLine("{0:G}", ido);
            //Console.WriteLine("{0:M}", ido);
            //Console.WriteLine("{0:r}", ido);
            //Console.WriteLine("{0:Y}", ido);
            //Console.WriteLine("{0:yyyy-mm-dd, dddd tt hh:mm:ss}", ido);

            //var uiCulture = CultureInfo.CurrentUICulture;
            //var currentCulture = CultureInfo.CurrentCulture;
            //var angolCulture = CultureInfo.CreateSpecificCulture("en-US");

            //double d = 1.2579;

            //Console.WriteLine("uiCulture: {0}", uiCulture.Name);
            //Console.WriteLine("currentCulture: {0}", currentCulture.Name);

            //var current = string.Format(currentCulture, "{0}, {1}, {2:C}", d, DateTime.Now, 32580);
            //var angol = string.Format(angolCulture, "{0}, {1}, {2:C}", d, DateTime.Now, 32580);
            //Console.WriteLine(current);
            //Console.WriteLine(angol);

            //var angolFormat = Convert.ToDouble("3.14", angolCulture);
            //Console.WriteLine(angolFormat);

            //string teszt = "🐰";
            //Console.WriteLine("A szoveg hossza: {0}", teszt.Length);

            //var info = new StringInfo(teszt);
            //Console.WriteLine("A szoveg valodi hossza: {0}", info.LengthInTextElements);

            //double b = Math.Ceiling(1.12);

            //Console.Write("Add meg a kör sugarát: ");
            //int r = Convert.ToInt32(Console.ReadLine());

            //double ker = 2 * r * Math.PI;
            //double ter = Math.Pow(r, 2) * Math.PI;

            //Console.WriteLine($"A kör kerülete: {Math.Round(ker, 2)}");
            //Console.WriteLine($"A kör területe: {Math.Round(ter, 2)}");


            //Console.WriteLine("Menü program");
            //Console.WriteLine("Opciók:");
            //Console.WriteLine("A: Kis kávé, B: Nagy kávé");
            //Console.WriteLine("C: Nem iszom semmit");
            //Console.Write("Kérem válasszon!: ");
            //var gomb = (char)Console.Read();

            //if (gomb == 'A' || gomb == 'a')
            //{
            //    Console.WriteLine("Kis kávét választott");
            //}
            //else if (gomb == 'B' || gomb == 'b')
            //{
            //    Console.WriteLine("Nagy kávét választott");
            //}
            //else if (gomb == 'C' || gomb == 'c')
            //{
            //    Console.WriteLine("Kár");
            //}
            //else
            //{
            //    Console.WriteLine("Nem jó gombot nyomott!");
            //}
            //Console.ReadKey();

            //Console.WriteLine("Kettővel szorzó v. 1.0");
            //Console.WriteLine("Adjon meg egy egész páros számot!");
            //try
            //{
            //    var bevitel = Console.ReadLine();
            //    int szam = Convert.ToInt32(bevitel);

            //    if ((szam % 2) != 0)
            //    {
            //        throw new Exception("A szám nem páros");
            //    }
            //    Console.WriteLine($"A szorzás eredménye: {szam * 2}");

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("HIBA történt");
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Program vége. Nyomjon egy gombot a kilépéshez");
            //    Console.ReadKey();
            //}

            Console.Write("Add meg a négyzet egy oldalát: ");
            try
            {
                var a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(4 * a);
            }
            catch (Exception ex)
            {
                Console.WriteLine("HIBA történt");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program vége. Nyomjon egy gombot a kilépéshez");
                Console.ReadKey();
            }*/

            /*Console.WriteLine("Add meg a négyzet oldalát: ");
            try
            {
                var a = Console.ReadLine();
                int kerulet = Convert.ToInt32(a) * 4;
                int terulet = Convert.ToInt32(a) * Convert.ToInt32(a);
                Console.WriteLine(kerulet, terulet);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Valami hiba történt: {0}", ex.Message);
            }
            Console.ReadKey();*/

            /*Console.WriteLine("Goto példa. Kilépés: CTRL+C");
        eleje:
            Console.WriteLine("Add meg a neved!");
            var nev = Console.ReadLine();
            Console.WriteLine($"Szia {nev}!");
            goto eleje;*/

            /*for (int i = 8; i < 100; i+=8)
            {
                Console.WriteLine(i);
            }*/

            /*int i = 10;
            while (i-- > 0)
            {
                Console.WriteLine(i);
            }*/

            /*int szam = -1;
            do
            {
                try
                {
                    Console.WriteLine("Adjon meg egy 1 és 10 közötti páros számot!");
                    string szoveg = Console.ReadLine();
                    szam = Convert.ToInt32(szoveg);
                }
                catch (Exception)
                {
                    szam = -1;
                }
            }
            while ((szam < 1) || (szam > 10) || ((szam % 2) != 0));

            Console.WriteLine("A megadott szám: {0}", szam);*/

            /*Console.WriteLine("Break példa");
            for (int i = 0; i < 100; i++)
            {
                Console.Write("{0} ", i);
                if (i == 10)
                {
                    break;
                }
            }

            Console.WriteLine("Continue példa");
            int j = 30;
            while (j-- > 0)
            {
                if (j % 3 == 0)
                {
                    continue;
                }
                Console.Write("{0} ", j);
            }*/

            /*var gyumolcsok = new string[]
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
            Console.ReadKey();
        }
    }
}
