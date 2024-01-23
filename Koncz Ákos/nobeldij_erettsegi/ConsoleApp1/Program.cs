using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. feladat

            List<Dijazott> dijazottak = new List<Dijazott>();

            foreach (var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                dijazottak.Add(new Dijazott(i));
            }

            // 3. feladat

            Console.WriteLine($"3. feladat: Díjazottak száma: { dijazottak.Count } fő");

            // 4. feladat

            int utolsoev = dijazottak.First().Év;

            foreach (var i in dijazottak.Skip(1))
            {
                if (i.Év > utolsoev)
                {
                    utolsoev = i.Év;
                }
            }

            Console.WriteLine($"4. feladat: Utolsó év: { utolsoev }");

            //5. feladat



            Console.ReadKey();
        }
    }
}
