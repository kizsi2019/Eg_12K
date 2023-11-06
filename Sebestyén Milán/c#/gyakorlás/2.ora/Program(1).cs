class Program
{
    static void Main(string[] args)
    {
        /*
        //0-t ír ki, mivel x int és a 4 is int
        int x = 3;
        Console.WriteLine(x / 4);

        //0,75 mert az x átkonvertálódik double típusra
        Console.WriteLine((double)x / 4);

        Console.WriteLine(  "kerek egy negyzet oldalnak a hosszat");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine( "kerulete: "+ 4*a);
        Console.WriteLine(  "terulet: "+ a*a);

        int ma = 21;
            int tegnap = 18;
            var szoveg = string.Format("Ma {0} fok volt, tegnap pedig {1}", ma, tegnap);

            Console.WriteLine(szoveg);

            Console.WriteLine("Így is lehet: {0}, {1}", ma, tegnap);
            Console.ReadKey();

        
            Console.WriteLine("Pénz: {0:C1}", 3148);
            Console.WriteLine("Százalék: {0:P3}", 0.123456);
            Console.WriteLine("Általános: {0:G}", 132354);
            Console.WriteLine("Exponenciális: {0:E}", 132354);
            Console.WriteLine("Hexa: {0:X}", 255);
            Console.ReadKey();


        double d = 1500.42;

            //1500,4200
            Console.WriteLine("{0:00.0000}", d);
            //(1500),42
            Console.WriteLine("{0:(#).##}", d);
            //1500,4
            Console.WriteLine("{0:0.0}", d);
            //1 500
            Console.WriteLine("{0:0,0}", d);
            //150042%
            Console.WriteLine("{0:0%}", d);
            //[Foo  ]
            Console.WriteLine("[{0,-5}]", "Foo");
            //[  Foo]
            Console.WriteLine("[{0,5}]", "Foo");

            //pozitív
            Console.WriteLine("{0:pozitív;negatív;nulla}", 4);
            //negatív
            Console.WriteLine("{0:pozitív;negatív;nulla}", -4);
            //nulla
            Console.WriteLine("{0:pozitív;negatív;nulla}", 0);
            Console.ReadKey();




        string nev = "world";
        string hello=$"hello"{nev};
        Console.WriteLine(  hello);


        //decimal Math.Abs(decimal value);
        //double Math.Abs(double value);
        //int Math.Abs(int value);
        //short Math.Abs(short value);
        //long Math.Abs(long value);
        //sbyte Math.Abs(sbyte value);

        double b = Math.Ceiling(1.12);


        


        Console.WriteLine("kerem a kor sugarat");
        int sugar = Convert.ToInt32(Console.ReadLine());

        double kerulet =Math.Round( Math.PI * 2 * Convert.ToDouble(sugar),2);
        double terulet =Math.Round( Math.Pow(sugar, 2) * Math.PI,2);
        Console.WriteLine( "kerulete: "+ kerulet);
        Console.WriteLine( "terulete: "+ terulet);


        Console.ReadLine();
        

        string szoveg = "valami szöveg";
        int szam = Convert.ToInt32(szoveg);
        Console.WriteLine(szam);
        Console.ReadKey();

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
            }
            Console.ReadKey();


        */
        /*
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



       Console.WriteLine(  "ad meg a negyzet oldalat");

       try
       {
           var bevit = Console.ReadLine();
           int szam;
           if (int.TryParse(bevit, out szam)) {
               Console.WriteLine("oldal: " + szam * 4);
               Console.WriteLine("terulet: " + szam * szam);
           }
           else { throw new Exception("ez nem szam"); }


       }
       catch (Exception ex)
       {
           Console.WriteLine("HIBA történt");
           Console.WriteLine(ex.Message);
       }



           Console.WriteLine("Goto példa. Kilépés: CTRL+C");
       eleje:
           Console.WriteLine("Add meg a neved");
           var nev = Console.ReadLine();
           Console.WriteLine($"Szia {nev}!");
           goto eleje;


       for (int i = 8; i < 100; i+=8) {
           Console.WriteLine( i);
       }


       Console.ReadKey();


       Console.WriteLine("0 -> 10");
       for (int i = 0; i < 10; i++)
       {
           Console.Write("{0}, ", i);
       }

       //itt már nem definiálhatunk i változót
       //int i = 22;

       Console.WriteLine("\n10 -> 0");
       for (int i = 10; i >= 0; i--)
       {
           Console.Write("{0}, ", i);
       }

       Console.WriteLine("\n0 -> 60, minden 3.");
       for (int i = 0; i < 60; i += 3)
       {
           Console.Write("{0}, ", i);
       }

       int i = 0;
       while (i < 10)
       {
           Console.Write(i);
           i++;
       }

        int szam = -1;
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
           Console.ReadKey();

        */
        /*
        Console.WriteLine("Break példa");
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
        Console.ReadKey();
        */
        /*
         class Program
    {
        static unsafe void Negyzet(int* p)
        {
            *p *= *p;
        }

        unsafe static void Main()
        {
            int i = 5;
            //& érték átadás, mint C esetén
            Negyzet(&i);
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
        */



}

}
