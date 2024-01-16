namespace Property1
{
    internal class Program
    {
        class Ember
        {
            public Ember(string n, int é, int isz) {
                Név = n; Életkor = é; Irányítószám = isz;
            }
            private string nev;
            public string Név { get { return nev; } set { if (value.Length != 0) { nev = value; } else Exception("amezo nem lehet ures"); } }
            private int eletkor;
            public int Életkor { get { return eletkor; } set { if (value >= 0) { eletkor = value; } else Exception("amezo nem lehet negativ"); } }
            private int iranyitoszam;
            public int Irányítószám { get { return iranyitoszam; } set { if (value.ToString().Length == 4) { iranyitoszam = value; } else Exception("amezo nem lehet negativ"); } }
            private void Exception(string s)
            {
                throw new FormatException(s);
            }
        }
        static void Main(string[] args)
        {
            Ember e = new Ember("Józsi", 12, 1111);
            Console.WriteLine(e.Név);
            Console.WriteLine(e.Életkor);
            Console.WriteLine(e.Irányítószám);

        }



    }
}