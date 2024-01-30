namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<NapiMunka> diszeks = new List<NapiMunka>();
            foreach(var i in File.ReadAllLines("diszek.txt"))
            {
                diszeks.Add(new NapiMunka(i));
            }
            //4
            Console.WriteLine(NapiMunka.KeszultDb);

            //5

            bool nemdisz = false;
            foreach (NapiMunka item in diszeks)
            {
                if (item.HarangKesz==0&& item.AngyalkaKesz==0&&item.FenyofaKesz==0)
                {
                    nemdisz = true;
                    break;
                }
            }
            if (nemdisz)
            {
                Console.WriteLine("volt olyan nap, amikor a hölgy egyetlen díszt sem készített!");
            }
            else { Console.WriteLine("nem volt olyan nap, amikor a hölgy egyetlen díszt sem készített!"); }


            //6

            int nap = 0;

            do
            {
                Console.WriteLine("kerek egy szamor 1-40 között");
                nap = int.Parse(Console.ReadLine());

            }
            while (nap < 1 || nap > 40);
            int harang = 0;
                int angyal = 0;
            int fenyo = 0;
            for (int i = 0; i < nap; i++)
            {
                harang += diszeks[i].HarangKesz + diszeks[i].HarangEladott;
                angyal += diszeks[i].AngyalkaEladott + diszeks[i].AngyalkaKesz;
                fenyo += diszeks[i].FenyofaEladott + diszeks[i].FenyofaKesz;

            }
            Console.WriteLine($"az {nap}-on {angyal}-angyalt, {harang}-harangot, és {fenyo}-t maradt meg");

            //7
            
            int an = 0;
            int har = 0;
            int fe = 0;
            foreach (var item in diszeks)
            {
                an += item.AngyalkaEladott;
                har += item.HarangEladott;
                fe += item.FenyofaEladott;
            }
            



        }
    }
}