namespace cbradio
{
    internal class Program
    {
        struct Taxi
        {
            public int ora { get; set; }
            public int perc { get; set; }
            public int id { get; set; }
            public string name { get; set; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<Taxi> taxi = new List<Taxi>();
            foreach (var item in File.ReadAllLines("bukkm2019.txt").Skip(1))
            {
                string[] sor = item.Split(';');
                taxi.Add(new Taxi { ora = int.Parse(sor[0]),
                    perc = int.Parse(sor[1]),

                    });
            }
        }
    }
}