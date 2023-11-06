using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static List<Feladvany> lista = new List<Feladvany>();

    static void Main(string[] args)
    {
        StreamReader read = new StreamReader("feladvanyok.txt", Encoding.UTF8);
        string sor = "";
        while (!read.EndOfStream)
        {
            sor = read.ReadLine();
            Feladvany hozza = new Feladvany(sor);
            lista.Add(hozza);
        }
        read.Close();

        Console.WriteLine("3. feladat");
        Console.WriteLine("Feladványok száma: " + lista.Count);

        Console.WriteLine("4. feladat");
        int meret;
        do
        {
            Console.Write("Kérem a sudoku méretét: ");
            meret = Convert.ToInt32(Console.ReadLine());
        } while (meret < 4 || meret > 9);

        int meretdb = 0;
        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i].Meret == meret)
            {
                meretdb++;
            }
        }
        Console.WriteLine("A megadott méretből ennyi van: " + meretdb);
        Console.WriteLine("{0}x{0} méretű feladványból {1} darab van tárolva", meret, meretdb);

        Console.WriteLine("5. feladat");
        Random rand = new Random();
        int kivalIndex = 0;
        do
        {
            kivalIndex = rand.Next(0, lista.Count);
        } while (lista[kivalIndex].Meret != meret);
        Console.WriteLine("A kisorsolt feladvány kezdő állapota: "
            + lista[kivalIndex].Kezdo);
    }
}