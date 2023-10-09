using System;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string szoveg = "valami szöveg";
            int szam = Convert.ToInt32(szoveg);
            Console.WriteLine(szam);
            Console.ReadKey();
            __________________________________________________________________________*/
            /*
            try
            {
                string szoveg_2 = "valami szöveg";
                int szam_2 = Convert.ToInt32(szoveg);
                Console.WriteLine(szam);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Valami hiba történt: {0}", ex.Message);
                throw; //hibát tovább dobjuk.
            }
            Console.ReadKey();

            ________________________________________________________________________*/

            /*
            Console.WriteLine("Kettővel szorzó v. 1.0");
            Console.WriteLine("Adjon meg egy egész páros számot!");
            try
            {
                var bevitel = Console.ReadLine();
                int szam_3 = Convert.ToInt32(bevitel);

                if ((szam_3 % 2) != 0)
                {
                    throw new Exception("A szám nem páros");
                }
                Console.WriteLine($"A szorzás eredménye: {szam_3 * 2}");

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

            //Feladat:
            /*try
            {
                Console.WriteLine("Add meg a négyzet oldalát mm-ben: ");
                string szoveg = Console.ReadLine();
                int szam = Convert.ToInt32(szoveg);
                double kerulet = szam * 4;
                double terulet = Math.Pow(szam, 2);
                Console.WriteLine("A négyzet kerülete: ", kerulet);
                Console.WriteLine("A négyzet terulete: ", terulet);
            }
            catch(FormatException ex)
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

            /*for(int i = 8; i < 101 ; i += 8)
            {
                Console.WriteLine(i);
            }*/


            /*int i = 0;
            while (i < 10)
            {
                Console.Write(i);
                i++;
            }
            Console.ReadKey(); */

            /*int i = 10;
            while (i-- > 0)
            {
                Console.Write(i);
            }
            Console.ReadKey();*/

            //Do-While
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

            Console.WriteLine("A megadott szám: {0}", szam);
            Console.ReadKey();*/

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
            }
            Console.ReadKey();*/
        }
    }
}

