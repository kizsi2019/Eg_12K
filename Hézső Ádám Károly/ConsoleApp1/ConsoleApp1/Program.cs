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
            List<string> lista = new List<string>();
            foreach (string item in File.ReadLines("megallok.txt", Encoding.UTF8))
            {
                lista.Add(item);
            }
            string output = "";
            foreach (string item in lista)
            {
                output += $"\"{item}\",";
            }
            output = output.Trim(',');
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
