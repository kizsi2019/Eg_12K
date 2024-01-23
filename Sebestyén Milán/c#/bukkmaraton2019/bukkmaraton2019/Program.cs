namespace bukkmaraton2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzos = new List<Versenyzo>();
            foreach (var item in File.ReadAllLines("bukkm2019.txt").Skip(1))
            {
                versenyzos.Add(new Versenyzo(item));
            }
            Console.WriteLine($"versenytav nem teljesitettek: {(1-versenyzos.Count/691.0)*100}");

            int ja = 0;
            foreach (var item in versenyzos)
            {
                if (item.Noiversenyzo && Tav== "Rövid")
                {
                    ja++;
                }

            }
            Console.WriteLine($"5. feladat: {ja}");

            Console.WriteLine($"6. : {Tobbhatora.count ? "volt" : "nincs"}");
            Versenyzo ferfirovid = null;
            foreach (var item in versenyzos)
            {
                if (item.Tav=="Rövid" && item.Kategoria=="ff")
                {
                    if (ferfirovid==null)
                    {

                    }
                    else
                    {
                        if (item.Ido < ferfirovid.Ido)
                        {
                            ferfirovid = item;
                        }
                    }
                }
                
            }
            Console.WriteLine(ferfirovid.Rajtszam);
            Console.WriteLine(ferfirovid.Nev);
            Console.WriteLine(ferfirovid.Ido);


            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var item in versenyzos)
            {
                int count1 = 0;
                foreach (var item2 in versenyzos)
                {
                    if (item.Kategoria == item2.Kategoria && !item2.Noiversenyzo())
                    {
                        count1++;
                    }
                }
                if (count1 > 0)
                {
                    dict[item.Kategoria] = count1;
                }
            }
            Console.WriteLine("8. feladat: Statisztika");
            foreach (KeyValuePair<string, int> item in dict)
            {
                Console.WriteLine($"\t{item.Key} - {item.Value} fő");
            }





            Console.ReadKey();
        }
    }
}