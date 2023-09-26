using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Orai_Munka_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Szia uram!");
            Console.Beep(140, 2000);
            Console.Clear();
            int x = 3;
            Console.WriteLine(x/4);
            Console.WriteLine((double)x/4);
            Console.WriteLine("Kérem a négyzet oldalát mm-ben: ");
            string mm = Console.ReadLine();
            int n_mm = Convert.ToInt32(mm);
            int n_mm_k = n_mm * 4;
            int n_mm_t = n_mm * n_mm;
            Console.WriteLine("A négyzet kerülete: " + n_mm_k + "mm");
            Console.WriteLine("A négyzet területe: " + n_mm_t + "mm");
            Console.ReadKey();
            Console.WriteLine("Pénz: {0:C1}", 3148);
            Console.WriteLine("Százalék: {0:P3}", 0.123456);
            Console.WriteLine("Általános: {:G}", 132354);
            Console.WriteLine("Exponenciális: {0:E}", 132354);
            Console.WriteLine("Hexa: {0:X}", 255);
            Console.ReadKey();
            string nev = "Wrold";
            string hello = $"Hello {nev}";
            Console.WriteLine(hello);

            /*Console.WriteLine("Kérem a kör átmérőjét cm-ben: ");
            string k_d = Console.ReadLine();
            int d = Convert.ToInt32(k_d);
            double pi = Math.PI;
            double r = d / 2;
            double k = 2 * r * pi;
            double t = r * r * pi;
            double k_r = Math.Round(k, 2);
            double t_r = Math.Round(t, 2);
            Console.WriteLine("A kör kerülete: " + k_r + "cm");
            Console.WriteLine("A kör területe: " + t_r + "cm");

            Console.WriteLine("Kérem, válasszon: ");
            var gomb = (char)Console.Read();
            switch (gomb)
            {

            }
            try
            {
                string szoveg = "valami szöveg";
                int szam = Convert.ToInt32(szoveg);
                Console.WriteLine(szam);
                Console.ReadKey();
            }
            catch(FormatException ex){
                Console.WriteLine("Valami hiba történt {0}", ex.Message);
            }
            Console.ReadKey();*/

            Console.WriteLine("Kettővel szorzó v 1.0");
            Console.WriteLine("Adjon meg egy páros számot");
            try
            {
                var bevitel = Console.ReadLine();
                int szam = Convert.ToInt32(bevitel);

                if ((szam % 2) != 0)
                {
                    Console.WriteLine("ERROR");
                }
            }
        }
    }
}