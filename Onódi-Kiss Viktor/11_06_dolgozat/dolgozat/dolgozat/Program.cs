using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat
{
    internal class Program
    {
        static string Atlag(double[] jegyek, string name)
        {
            double sum = 0;

            for(int i = 0; i < jegyek.Length; i++)
            {
                sum += jegyek[i];
            }

            return $"{name.ToUpper()} átlaga: {Math.Round((sum / jegyek.Count()), 2)}";
        }

        static string Max(double[] jegyek, string name)
        {
            double max = jegyek[0];

            for (int i = 0; i < jegyek.Length; i++)
            {
                if (jegyek[i] > max)
                {
                     max = jegyek[i];
                }
            }

            return $"{name.ToUpper()} legjobb jegye: {max}";
        }

        static string Min(double[] jegyek, string name)
        {
            double min = jegyek[0];

            for (int i = 0; i < jegyek.Length; i++)
            {
                if (jegyek[i] < min)
                {
                    min = jegyek[i];
                }
            }

            return $"{name.ToUpper()} legrosszabb jegye: {min}";
        }

        //1. feladat
        private static void Bekeres()
        {
            string name = "";

            while (name.Count() == 0)
            {
                Console.Write("Adj meg egy nevet: ");
                name = Console.ReadLine();
            }


            bool siker = true;
            double[] jegyek;

            do
            {
                string jegyekS = "";

                while (jegyekS.Count() == 0)
                {
                    Console.Write("Add meg az osztályzatait egy bizonyos tárgyból, vesszővel elválasztva: ");
                    jegyekS = Console.ReadLine();
                }

                string[] jegyekSplit = jegyekS.Split(',');

                jegyek = new double[jegyekSplit.Count()];



                for (int i = 0; i < jegyekSplit.Count(); i++)
                {
                    try
                    {
                        jegyek[i] = Convert.ToDouble(jegyekSplit[i]);
                    }
                    catch
                    {
                        Console.WriteLine("Hiba, nem megfelelő formátum!");
                        siker = false;
                    }
                }
            } while (!siker);

            Console.WriteLine(Atlag(jegyek, name));
            Console.WriteLine(Max(jegyek, name));
            Console.WriteLine(Min(jegyek, name));
        }

        //2. feladat
        private static string Palindrom()
        {

            Console.Write("Adj meg egy szót kérlek: ");
            string txt = Console.ReadLine();

            bool palindrom = true;

            if(txt.Count() < 2)
            {
                return "Palindrom";
            }

            for(int i = 0; i < Math.Floor(txt.Count()/(double)2); i++)
            {
                palindrom = palindrom && txt[i] == txt[txt.Count()-1 - i];
            }

            return (palindrom ? "Palindrom" : "Nem palindrom");

        }


        static void Main(string[] args)
        {
            Bekeres();
            Console.WriteLine(Palindrom());
            Console.ReadKey();
        }
    }
}
