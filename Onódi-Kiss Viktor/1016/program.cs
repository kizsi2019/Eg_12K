using System.IO;


namespace program{
    class Program{

        static bool Paros(int a, out bool log){
            if(a % 2 == 0){
                log = true;
            }
            else{
                log = false;
            }
            return log;
        }

        public static void Main(string[] args){
            bool paros;
            Console.WriteLine(Paros(10, paros));

            Console.WriteLine("A megadott szám: " + EllBekerf("Adj meg egy zsámot 10 és 20 között: ", 10, 20));
            Console.ReadKey();
        }

        static int EllBekerf(int bekeresuzi, int mettol = int.MinValue, int meddig = int.MaxValue){
            int szam;
            do{
                Console.WriteLine(bekeresuzi);
            }while(!int.TryParse(Console.ReadLine(), out szam) || (szam > mettol && szam < meddig))
            return szam;
        }
    }
}