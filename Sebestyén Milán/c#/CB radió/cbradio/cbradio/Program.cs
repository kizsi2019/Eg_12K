namespace cbradio
{
    internal class Program
    {
        struct Taxi
        {
            public int Ora { get; set; }
            public int Perc { get; set; }
            public int AdasDb { get; set; }
            public string Nev { get; set; }
        }

        private int AtszamolPercre(int ora, int perc) => ora * 60 + perc;

        public int Kezdes => AtszamolPercre(Ora,Perc);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<Taxi> taxi = new List<Taxi>();
            foreach (var item in File.ReadAllLines("bukkm2019.txt").Skip(1))
            {
                string[] sor = item.Split(';');
                taxi.Add(new Taxi { Ora = int.Parse(sor[0]),
                    Perc = int.Parse(sor[1]),
                    AdasDb = int.Parse(sor[2]),
                    Nev = sor[3]

                });
                
                Console.WriteLine($"3. feladat: Bejegyzések száma: {taxi.Count} db");

                bool volt4esBejegyzes = false;
                foreach (var i in taxi)
                {
                    if (i.AdasDb == 4)
                    {
                        volt4esBejegyzes = true;
                        break;
                    }
                }
                Console.WriteLine($"4. feladat: {(volt4esBejegyzes ? "Volt" : "Nem volt")} négy adást indító sofőr.");



                Console.Write("5. feladat: Kérek egy nevet: ");
                string inputNev = Console.ReadLine();
                int adasDb = 0;
                foreach (var i in taxi)
                {
                    if (i.Nev == inputNev) adasDb += i.AdasDb;
                }
                if (adasDb == 0) Console.WriteLine("\tNincs ilyen nevű sofőr!");
                else Console.WriteLine($"\t{inputNev} {adasDb}x használta a CB-rádiót.");



                List<string> ki = new List<string>();
                ki.Add("Kezdes;Nev;AdasDb");
                foreach (var i in taxi)
                {
                    ki.Add($"{i.Kezdes};{i.Nev};{i.AdasDb}");
                }
                File.WriteAllLines("cb2.txt", ki);



                HashSet<string> nevek = new HashSet<string>();
                foreach (var i in taxi)
                {
                    nevek.Add(i.Nev);
                }
                Console.WriteLine($"8. feladat: Sofőrök száma: {nevek.Count} fő");



                Dictionary<string, int> stat = new Dictionary<string, int>();
                foreach (var i in taxi)
                {
                    if (stat.ContainsKey(i.Nev)) stat[i.Nev] += i.AdasDb;
                    else stat.Add(i.Nev, i.AdasDb);
                }
                string maxAdoNev = stat.First().Key;
                int maxAdasDb = stat.First().Value;
                foreach (var i in stat.Skip(1))
                {
                    if (i.Value > maxAdasDb)
                    {
                        maxAdasDb = i.Value;
                        maxAdoNev = i.Key;
                    }
                }
                Console.WriteLine("9. feladat: Legtöbb adást indító sofőr");
                Console.WriteLine($"\tNév: {maxAdoNev}");
                Console.WriteLine($"\tAdások száma: {maxAdasDb} alkalom");



            }
        }
    }
}