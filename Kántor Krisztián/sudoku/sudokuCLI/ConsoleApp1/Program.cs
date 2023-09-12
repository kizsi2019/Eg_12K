using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        struct Fel4x4
        {
            public string sol { get; set; }
        }
        struct Fel5x5
        {
            public string sol { get; set; }
        }
        struct Fel6x6
        {
            public string sol { get; set; }
        }
        struct Fel7x7
        {
            public string sol { get; set; }
        }
        struct Fel8x8
        {
            public string sol { get; set; }
        }
        struct Fel9x9
        {
            public string sol { get; set; }
        }

        static List<Fel4x4> four = new List<Fel4x4>();
        static List<Fel5x5> five = new List<Fel5x5>();
        static List<Fel6x6> six = new List<Fel6x6>();
        static List<Fel7x7> seven = new List<Fel7x7>();
        static List<Fel8x8> eight = new List<Fel8x8>();
        static List<Fel9x9> nine = new List<Fel9x9>();
        static void Main(string[] args)
        {
            Import();
            Console.WriteLine(four.Count() + five.Count() + six.Count() + seven.Count() + eight.Count() + nine.Count());

        }


        static void Import()
        {
            System.IO.StreamReader read = new System.IO.StreamReader("feladvanyok.txt", System.Text.Encoding.UTF8);
            while (!read.EndOfStream)
            {
                string line = read.ReadLine();
                if (line.Length == 16)
                {
                    four.Add(new Fel4x4 {
                        sol = line
                    });
                }

                else if (line.Length == 25)
                {
                    five.Add(new Fel5x5
                    {
                        sol = line
                    });
                }

                else if (line.Length == 36)
                {
                    six.Add(new Fel6x6
                    {
                        sol = line
                    });
                }

                else if (line.Length == 49)
                {
                    seven.Add(new Fel7x7
                    {
                        sol = line
                    });
                }

                else if (line.Length == 64)
                {
                    eight.Add(new Fel8x8
                    {
                        sol = line
                    });
                }

                else if (line.Length == 81)
                {
                    nine.Add(new Fel9x9
                    {
                        sol = line
                    });
                }
            }

        }

        static int HowMany(int something)
        {
            int num = 0;
            if (something==4)
            {
                num= four.Count(); 
            }

            else if (something == 5)
            {
                num= five.Count();
            }

            else if (something == 6)
            {
                num= six.Count();
            }

            else if (something == 7)
            {
                num = seven.Count();
            }

            else if (something == 8)
            {
                num = eight.Count();
            }

            else if (something == 9)
            {
                num = nine.Count();
            }
            return num;
        }
    }
}
