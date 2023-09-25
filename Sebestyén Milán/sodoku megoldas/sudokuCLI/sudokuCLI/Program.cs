using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudokuCLI
{

    class Program
    {
        struct feladvany
        {
            public int row { get; set; }
        }

        static void Main(string[] args)
        {
            Import();
            Console.WriteLine("3. feladat");
            Console.WriteLine();
            
        }
        List<feladvany> lista = new List<feladvany>();
        static void Import()
        {
            System.IO.StreamReader read = new System.IO.StreamReader("feldvanyok.txt");
            while (!read.EndOfStream)
            {
                
            }
        }

    }
}
