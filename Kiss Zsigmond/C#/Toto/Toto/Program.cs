﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Toto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<FogadasiFordulo> fordulók = new List<FogadasiFordulo>();
            foreach (var i in File.ReadAllLines("toto.txt").Skip(1))
            {
                fordulók.Add(new FogadasiFordulo(i));
            }

            Console.WriteLine($"3. feladat: Fordulók száma: {fordulók.Count}");

            // 4. feladat:
            int szelvény13p1Db = 0;
            foreach (var i in fordulók)
            {
                szelvény13p1Db += i.TelitalálatDarab;
            }
            Console.WriteLine($"4. feladat: Telitalálatos szelvények száma: {szelvény13p1Db} db");

            // 5. feladat:
            double nyereményekÖsszege = 0;
            int telitalálatosFordulóDb = 0;
            foreach (var i in fordulók)
            {
                checked
                {
                    nyereményekÖsszege += i.NyereményÖsszeg;
                    telitalálatosFordulóDb++;
                }
            }
            Console.WriteLine($"5. feladat: Átlag: {nyereményekÖsszege / telitalálatosFordulóDb:F0} Ft");

            Console.WriteLine("6. feladat:");
            int maxi = -1;
            int mini = -1;
            for (int i = 1; i < fordulók.Count; i++)
            {
                if (fordulók[i].TelitalálatDarab > 0)
                {
                    if (maxi == -1) maxi = i;
                    if (mini == -1) mini = i;
                    if (fordulók[i].TelitalálatNyeremény > fordulók[maxi].TelitalálatNyeremény)
                    {
                        maxi = i;
                    }
                    if (fordulók[i].TelitalálatNyeremény < fordulók[mini].TelitalálatNyeremény)
                    {
                        mini = i;
                    }
                }
            }
            Console.WriteLine("\tLegnagyobb:");
            fordulók[maxi].EredménytKiír();
            Console.WriteLine("\n\tLegkisebb:");
            fordulók[mini].EredménytKiír();

            // 8. feladat:
            bool voltDöntetlenNélküliForduló = false;
            foreach (var i in fordulók)
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
