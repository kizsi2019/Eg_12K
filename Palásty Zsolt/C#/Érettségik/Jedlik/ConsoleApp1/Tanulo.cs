using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Tanulo
    {
       
            public int Ev { get; set; }
            public string Osztaly { get; set; }
            public string Nev { get; set; }

            public int Nevhosz
            {
                get
                {
                    return Nev.Replace(" ", "").Length;
                }

            }

            
            public string Azonosito
            {
                get
                {
                    string az = (Ev % 1000).ToString();
                    az += Osztaly;
                    string[] nevek = Nev.ToLower().Split(' ');
                    az += nevek[0].Substring(0, 3);
                    az += nevek[1].Substring(0, 3);

                    return az;
                }
            }


        }
    }


