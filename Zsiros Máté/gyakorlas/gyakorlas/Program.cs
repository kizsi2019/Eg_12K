﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace gyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            Console.WriteLine((double)x / 4);
            //Console.Beep(800, 2000000);

            /*Console.WriteLine("Add meg a négyzet oldalát.");
            int u = Convert.ToInt32(Console.ReadLine());
            int kerulet = 4 * u;
            int terulet = u * u;

            Console.WriteLine("Négyzet kerülete: " + kerulet);
            Console.WriteLine("Négyzet területe: " + terulet);

            Console.WriteLine("Pénz: {0:C1}", 3148);
            Console.WriteLine("Százalék: {0:P3}", 0.123456);
            Console.WriteLine("Általános: {0:G}", 132354);
            Console.WriteLine("Exponenciális: {0:E}", 132354);
            Console.WriteLine("Hexa: {0:X}", 255);

            string nev = "World";
            string hello = $"Hello {nev}";
            Console.WriteLine(hello);

            Console.WriteLine(DateTime.Now);

            var ido = DateTime.Now;

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

            var uiCulture = CultureInfo.CurrentUICulture;
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
            Console.WriteLine("A szoveg valodi hossza: {0}", info.LengthInTextElements);

            double b = Math.Ceiling(1.12);
            Console.WriteLine(b);
            int a = Math.Max(2, 3);
            Console.WriteLine(a);
            double c = Math.Round(1.2345, 2);
            Console.WriteLine(c);

            Console.WriteLine("Add meg a kör sugarát: ");
            int r = Convert.ToInt32(Console.ReadLine());

            var kerulet = Math.Round(2 * Math.PI * r, 2);
            var terulet = Math.Round(Math.PI * Math.Pow(r, 2));

            Console.WriteLine("A kör kerülete: " + kerulet + " és területe: " + terulet + ".");

            Console.WriteLine("Menü program");
            Console.WriteLine("Opciók:");
            Console.WriteLine("A: Kis kávé, B: Nagy kávé");
            Console.WriteLine("C: Nem iszom semmit");
            Console.Write("Kérem válasszon!: ");
            var gomb = (char)Console.Read();

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
                Console.WriteLine("Nem jó gombot nyomott!");
            }

            Console.WriteLine("Menü program");
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
            }

            string szoveg = "valami szöveg";
            int szam = Convert.ToInt32(szoveg);
            Console.WriteLine(szam);

            try
            {
                string szoveg = "valami szöveg";
                int szam = Convert.ToInt32(szoveg);
                Console.WriteLine(szam);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Valami hiba történt: {0}", ex.Message);
            }
            Console.ReadKey();

            try
            {
                string szoveg = "valami szöveg";
                int szam = Convert.ToInt32(szoveg);
                Console.WriteLine(szam);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Valami hiba történt: {0}", ex.Message);
                throw; //hibát tovább dobjuk.
            }*/

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
                Console.WriteLine("Program vége. Nyomjon egy gombot a kilépéshez");
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
