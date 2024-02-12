using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskola
{
    internal class JelszóGeneráló
    {
        private Random Rnd;
        public JelszóGeneráló(Random r)
        {
            Rnd = r;
        }
        public string Jelszó(int jelszóHossz)
        {
            string jelszó = "";
            while (jelszó.Length < jelszóHossz)
            {
                char c = (char)Rnd.Next(48, 123);
                if ((c >= '0' && c <= '9') || (c >= 'a' && c <= 'z'))
                {
                    jelszó += c;
                }
            }
            return jelszó;
        }
    }
}
