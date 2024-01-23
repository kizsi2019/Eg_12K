using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleApp1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2
            List<Dijazott> dijazottak = new List<Dijazott>();
            foreach (var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                dijazottak.Add(new Dijazott(i));
            }

            //3
            Console.WriteLine($"3.feladat: Díjazottak száma : {dijazottak.Count} fő");

            //4
            int utolsóÉv = dijazottak.First().Év;
            foreach(var i in dijazottak.Skip(1))
            {
                if(i.Év > utolsóÉv)
                {
                    utolsóÉv = i.Év;
                }
            }
            Console.WriteLine($"4. feladat: Utolsó év: {utolsóÉv}");

            //5


            Console.ReadKey();
        }
    }
}