namespace ConsoleApp3
{
    internal class Program
    {



        
        static void Main(string[] args)
        {
            List<Dijazott> dijazottak=new List<Dijazott>();
            foreach (var item in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                dijazottak.Add(new Dijazott(item));
            }

            Console.WriteLine(dijazottak.Count);

            //4
            int utolsoev = dijazottak.First().ev;
            foreach (var item in dijazottak.Skip(1))
            {
                if (item.ev>utolsoev)
                {
                    utolsoev = item.ev;
                }
            }

            Console.WriteLine(utolsoev);

            //6

            string orsz=Console.ReadLine();
            List<Dijazott> dijorsz=new List<Dijazott>();
            foreach (var item in dijazottak.Skip(1))
            {
                if (orsz == item.orszag)
                {
                    dijorsz.Add(item);
                }
            }
            if(dijorsz.Any()) {
                Console.WriteLine(dijorsz.First().nev);
                Console.WriteLine(dijorsz.First().ev);
                Console.WriteLine(dijorsz.First().szuleteshalal);
            }
            else { Console.WriteLine("nincs dijazott az országból"); }


            //7

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var item in dijazottak)
            {
                int count1 = 0;
                foreach (var item2 in dijazottak)
                {
                    if (item.orszag == item2.orszag)
                    {
                        count1++;
                    }
                }
                if (count1 > 5)
                {
                    dict[item.orszag] = count1;
                }
            }
            Console.WriteLine("8. feladat: Statisztika");
            foreach (KeyValuePair<string, int> item in dict)
            {
                Console.WriteLine($"\t{item.Key} - {item.Value}fo");
            }

            

            Console.ReadKey();


        }
    }
}