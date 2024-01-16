using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties1
{
    class Ember
    {
        public Ember(string n, int é, int isz)
        {
            Név = n;
            Életkor = é;
            Irányítószám = isz;
        }

        private string név;
        public string Név
        {
            get { return név;}
            set
            {
                if (value.Length != 0) név = value;
                else Exception("A név mező nem lehet üres");
            }
        }

        private int életkor;
        public int Életkor
        {
            get { return életkor; }
            set
            {
                if(value > 0)
                {
                    életkor = value;
                }
                else
                {
                    Exception("Az életkor nem lehet kevesebb mint 1");
                }
            }
        }

        private int irányítószám;
        public int Irányítószám
        {
            get
            {
                return irányítószám;
            }
            set
            {
                if(value.ToString().Length == 4)
                {
                    irányítószám = value;
                }
                else
                {
                    Exception("Az irányítószámnak 4 számból kell állnia");
                }
            }
        }

        private void Exception(string s)
        {
            throw new FormatException(s);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ember e = new Ember("Gipsz Jakab", 2003, 1135);
        }
    }
}
