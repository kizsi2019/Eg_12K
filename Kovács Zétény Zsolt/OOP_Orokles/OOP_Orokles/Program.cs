using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOP_Orokles.Program;

namespace OOP_Orokles
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
        static void Main(string[] args)
        {
            


            /*
            Teglalap t = new Teglalap(0, 0, 12, 10);
            Negyzet n = new Negyzet(0, 11, 6);
            t.Rajzol();
            n.Rajzol();
            Console.ReadKey();

            Köszönés_Üdvözlés kosz = new Köszönés_Üdvözlés();
            kosz.Reggel();
            kosz.Este();
            kosz.Napközben();
            */
        }



        //absztrakt ősosztály. A többi objektum őse
        public abstract class Ososztaly
        {
            //x és y koordináták, tulajdonságok, amiket csak olvasni lehet
            //viszont az ősosztály írhatja is őket
            public int X { get; private set; }
            public int Y { get; private set; }

            //absztrakt rajzoló függvény, minden leszármazott osztálynak meg kell valósítania
            public abstract void Rajzol();

            //konstruktor x és y koordináták beállítására
            public Ososztaly(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        //teglalap, ami az ősosztályból származik.
        //definiálja a Rajzol metódust, illetve két új tulajdonságot is
        /*public class Teglalap : Ososztaly
        {
            //Téglalap méretetét beállító tulajdonságok
            public int Szelesseg { get; private set; }
            public int Magassag { get; private set; }

            //konstruktor, ami az ősosztály konstruktorát is hívja
            public Teglalap(int x, int y, int szele, int magassag) : base(x, y)
            {
                Szelesseg = szele;
                Magassag = magassag;
            }

            //Rajzol függvény megvalósítása
            /* public override void Rajzol()
             {
                 Console.SetCursorPosition(X, Y);
                 for (int i = 0; i < Magassag; i++)
                 {
                     for (int j = 0; j < Szelesseg; j++)
                     {
                         if (i == 0 || i == Magassag - 1) Console.Write("-");
                         else
                         {
                             if (j == 0 || j == Szelesseg - 1) Console.Write("|");
                             else Console.Write(" ");
                         }
                     }
                     Console.WriteLine();
                 }
             }
         }*/

           /* //A négyzet megvalósítása
            public sealed class Negyzet : Teglalap
        {
            public Negyzet(int x, int y, int meret) : base(x, y, meret, meret) { }
        }
           */
                
       
        
    }
}
