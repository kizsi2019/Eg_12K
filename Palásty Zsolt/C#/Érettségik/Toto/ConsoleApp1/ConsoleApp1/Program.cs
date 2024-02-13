namespace ConsoleApp1
{
    internal class Program
    {
        class EredmenyElemzo
        {
            private string Eredmenyek;

            private int DontetlenekSzama
            {
                get
                {
                    return Megszamol('X');
                }
            }

            private int Megszamol(char kimenet)
            {
                int darab = 0;
                foreach (var i in Eredmenyek)
                {
                    if (i == kimenet) darab++;
                }
                return darab;
            }

            public bool NemvoltDontetlenMerkozes
            {
                get
                {
                    return DontetlenekSzama == 0;
                }
            }

            public EredmenyElemzo(string eredmenyek) // konstruktor
            {
                Eredmenyek = eredmenyek;
            }
        }
        class Data
        {
            public int ev { get; set; }
            public int het { get; set; }
            public int fordulo { get; set; }
            public int talalt { get; set; }
            public int nyert { get; set; }
            public string eredmenyek { get; set; }
        }

        static void Main(string[] args)
        {
            List<Data> adat = new List<Data>();
            foreach (var item in File.ReadAllLines("toto.txt").Skip(1))
            {
                string[] i = item.Split(';');
                adat.Add(new Data
                {
                    ev = int.Parse(i[0]),
                    het = int.Parse(i[1]),
                    fordulo = int.Parse(i[2]),
                    talalt = int.Parse(i[3]),
                    nyert = int.Parse(i[4]),
                    eredmenyek = i[5]
                });
            }
            //Feladat_3
            Console.WriteLine($"3. Feladat: fordulók száma: {adat.Count}");

            //Feladat_4
            int teiszelveny = 0;
            foreach (Data item in adat)
            {
                teiszelveny += item.talalt;
            }
            Console.WriteLine($"4. Feladat: Telitalalatos szelvenyek szama: {teiszelveny}db");


            //Feladat_5

            Int64 osznyeremeny = 0;
            int db = 0;
            foreach (Data item in adat)
            {
                osznyeremeny += item.nyert*item.talalt;
                
                    db++;
                
            }
            double avg =Math.Round( 1.00* osznyeremeny / db,0);
            Console.WriteLine($"5. Feladat: Átlag: {avg}ft");
            
            //Feladat_6

            List<Data> legkiss = new List<Data>();
            List<Data> legnagy = new List<Data>();
            foreach (Data item in adat)
            {
                if (item.nyert > 0)
                {
                    legkiss.Add(item);
                    legnagy.Add(item);
                }

            }
            foreach (Data item in adat)
            {
                if (item.nyert>0)
                {
                    if(item.nyert > legnagy[0].nyert)
                    {
                        legnagy.Clear();
                        legnagy.Add(item);
                    }
                    if (item.nyert < legkiss[0].nyert)
                    {
                        legkiss.Clear();
                        legkiss.Add(item);
                    }
                }
                
            }
            Console.WriteLine("6.Feladat:");
            Console.WriteLine($"Legnagyobb: \nÉv: {legnagy[0].ev} \nHét: {legnagy[0].het}. \nForduló: {legnagy[0].fordulo}. \nTelitalalat: {legnagy[0].talalt}db \nNyeremény: {legnagy[0].nyert}ft \nEredmenyek: {legnagy[0].eredmenyek}");
            Console.WriteLine($"Legnagyobb: \nÉv: {legkiss[0].ev} \nHét: {legkiss[0].het}. \nForduló: {legkiss[0].fordulo}. \nTelitalalat: {legkiss[0].talalt}db \nNyeremény: {legkiss[0].nyert}ft \nEredmenyek: {legkiss[0].eredmenyek}");





            //Feladat_8


            bool dontnelkul = false;

            foreach (var i in adat)
            {
                EredmenyElemzo ee = new EredmenyElemzo(i.eredmenyek);
                if (ee.NemvoltDontetlenMerkozes)
                {
                    dontnelkul = true;
                    break;
                }
            }
            Console.WriteLine($"8. feladat: {(dontnelkul ? "Volt" : "Nem volt")} döntetlen nélküli forduló!");








        }
    }
}