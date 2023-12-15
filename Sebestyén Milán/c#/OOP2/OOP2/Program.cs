namespace OOP2
{
    internal class Program
    {
        class Kutya
        {
            public string Név;
            private int Éhes = 50;
            public void Etet(int kaja)
            {
                Éhes -= kaja;
            }
            public void Játék()
            {
                if (Éhes <= 80)
                {
                    Éhes += 50;
                    Console.WriteLine("játék...");
                }
                else Console.WriteLine("a kutya  éhes");
            }
        }
        static void Main(string[] args)
        {
            Kutya kutya = new Kutya();
            kutya.Játék();
            kutya.Játék();
            kutya.Etet(90);
            kutya.Játék();
            kutya.Játék();
            kutya.Játék();
            Console.ReadKey();

        }
    }
}