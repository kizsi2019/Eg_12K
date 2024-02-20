namespace OPP_interface
{
    internal class Program
    {
        interface IKöszönés
        {
            void Reggel();
            void Este();
            void Napközben();
        }
        interface IÜdvözlés
        {
            void Szia(string név);
        }
        class Köszönés_Üdvözlés : IKöszönés, IÜdvözlés
        {
            public void Reggel() { Console.WriteLine("Jó reggelt!"); }
            public void Este() { Console.WriteLine("Jó estét!"); }
            public void Napközben() { Console.WriteLine("Jó napot!"); }
            public void Szia(string név) { Console.WriteLine("Szia {0}!", név); }
        }
        delegate void Beléptetés(string str);
        static void Üdvözlés(string név)
        {
            Console.WriteLine("Üdvözzöllek {0}!", név);
        }
        static void Üzenet(string név)
        {
            Console.WriteLine("Kedves {0}, köszönjük a belépésedet a rendszerbe...", név);
        }

        class Szám
        {
            public delegate void EseménykezelőDelegate(string str);
            public event EseménykezelőDelegate ÁllapotváltozásEsemény;
            int szam = 0;
            public int Szam
            {
                get { return szam; }
                set
                {
                    szam = value; //akkor indul be az esemény, ha megváltozik a szam mező:
                    ÁllapotVáltozás();
                }
            }
            private void ÁllapotVáltozás()
            {
                if (ÁllapotváltozásEsemény != null) ÁllapotváltozásEsemény("Megváltozott a szam mező!");
            }
        }
        static void EseményKezelés(string str)
        {
            Console.WriteLine(str);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Köszönés_Üdvözlés kesz =new Köszönés_Üdvözlés();
            kesz.Reggel();
            kesz.Este();
            kesz.Napközben();
            kesz.Szia("Deszö");

            Beléptetés b = new Beléptetés(Üdvözlés) + new Beléptetés(Üzenet);
            Console.Write("Add meg a nevedet: ");
            string név = Console.ReadLine();
            b(név);

            Szám sz = new Szám();
            sz.ÁllapotváltozásEsemény += EseményKezelés; //feliratkozunk az eseményre
            sz.Szam = 21; //kiváltjuk az eseményt;
            Console.ReadKey();


        }
        
            
            
        

    }
}