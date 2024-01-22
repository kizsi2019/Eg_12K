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

            Console.ReadKey();
        }
    }
}