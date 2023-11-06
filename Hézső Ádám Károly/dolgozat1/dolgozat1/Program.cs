using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat1
{
    class Program
    {
        public static void Bekeres()
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
                    Console.Write("Add meg a jegyeid vesszővel elválasztva: ");
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
            Console.WriteLine(jegyAtlag(jegyek, name));
            Console.WriteLine(Maxjegy(jegyek, name));
            Console.WriteLine(Minjegy(jegyek, name));
        }
        static string jegyAtlag(double[] jegyek, string name)
        {
            double sum = 0;
            for (int i = 0; i < jegyek.Length; i++)
            {
                sum += jegyek[i];
            }
            return $"{name.ToUpper()} átlaga: {Math.Round((sum / jegyek.Count()), 2)}";
        }
        static string Maxjegy(double[] jegyek, string name)
        {
            double maxjegy = jegyek[0];

            for (int i = 0; i < jegyek.Length; i++)
            {
                if (jegyek[i] > maxjegy)
                {
                    maxjegy = jegyek[i];
                }
            }
            return $"{name.ToUpper()} legjobb jegye: {maxjegy}";
        }
        static string Minjegy(double[] jegyek, string name)
        {
            double minjegy = jegyek[0];

            for (int i = 0; i < jegyek.Length; i++)
            {
                if (jegyek[i] < minjegy)
                {
                    minjegy = jegyek[i];
                }
            }

            return $"{name.ToUpper()} legrosszabb jegye: {minjegy}";
        }
        static void Main(string[] args)
        {
            Bekeres();
            Console.ReadKey();
        }
    }
}
