using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //2. Feladat
            List<FogadasiFordulo> Eredmeny_lista = new List<FogadasiFordulo>();
            foreach (var i in File.ReadAllLines("toto.txt").Skip(1))
            {
                Eredmeny_lista.Add(new FogadasiFordulo(i));
            }


            //3. Feladat
            Console.WriteLine($"A 3. feladat: Fordulók száma: {Eredmeny_lista.Count()}");

            //4. Feladat
            int szelvény13p1Db = 0;
            foreach (var i in Eredmeny_lista)
            {
                szelvény13p1Db += i.TelitalálatDarab;
            }
            Console.WriteLine($"4. feladat: Telitalálatos szelvények száma: {szelvény13p1Db} db");

            //5. Feladat 
            double nyeremeny_Oszzege = 0;
            int telitalalatDB = 0;

            foreach(var i in Eredmeny_lista)
            {
                checked
                {
                    nyeremeny_Oszzege += i.NyereményÖsszeg;
                    telitalalatDB++;
                }
            }
            Console.WriteLine($"5. feladat: Átlag:{Math.Round(nyeremeny_Oszzege/telitalalatDB),0} Ft");

            Console.WriteLine("6. feladat:");
            int maxi = -1;
            int mini = -1;
            for (int i = 1; i < Eredmeny_lista.Count; i++)
            {
                if (Eredmeny_lista[i].TelitalálatDarab > 0)
                {
                    if (maxi == -1) maxi = i;
                    if (mini == -1) mini = i;
                    if (Eredmeny_lista[i].TelitalálatNyereméy > Eredmeny_lista[maxi].TelitalálatNyereméy)
                    {
                        maxi = i;
                    }
                    if (Eredmeny_lista[i].TelitalálatNyereméy < Eredmeny_lista[mini].TelitalálatNyereméy)
                    {
                        mini = i;
                    }
                }
            }
            Console.WriteLine("\tLegnagyobb:");
            Eredmeny_lista[maxi].EredménytKiír();
            Console.WriteLine("\n\tLegkisebb:");
            Eredmeny_lista[mini].EredménytKiír();


            // 8. feladat:
            bool voltDöntetlenNélküliForduló = false;
            foreach (var i in Eredmeny_lista)
            {
                EredmenyElemzo ee = new EredmenyElemzo(i.Eredmények);
                if (ee.NemvoltDontetlenMerkozes)
                {
                    voltDöntetlenNélküliForduló = true;
                    break;
                }
            }
            Console.WriteLine($"8. feladat: {(voltDöntetlenNélküliForduló ? "Volt" : "Nem volt")} döntetlen nélküli forduló!");

            Console.ReadKey();
        }
    }
    
}

