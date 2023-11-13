using System;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Text;
using System.Threading.Tasks.Dataflow;
using System.Xml.Schema;

class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Nevet kerek: ");
        string neev = Console.ReadLine();
        bool ha = false;
        int jo = 0;

        Console.WriteLine("Jegyeket kerek vesszovel elvalasztva (1 és 5 között): ");
        string jeggyy;
        string[] jeggy;

        do
        {
            jeggyy = Console.ReadLine();
            jeggy = jeggyy.Split(',');

            // Ellenőrizzük, hogy minden jegy 1 és 5 között van-e
            ha = true;
            foreach (string item in jeggy)
            {
                int jegy = Convert.ToInt32(item);
                if (jegy < 1 || jegy > 5)
                {
                    ha = false;
                    Console.WriteLine("Hibás jegyeket adtál meg. Kérlek, csak 1 és 5 közötti értékeket adj meg.");
                    break;
                }
            }

        } while (!ha);

        int a = 0;
        foreach (string item in jeggy)
        {
            a += Convert.ToInt32(item);
        }
        double avvg = Convert.ToDouble(a) / jeggy.Length;
        double avg = Math.Round(avvg, 2);
        Console.WriteLine(neev + " átlaga: " + avg);

        int maxi = 0;
        foreach (string i in jeggy)
        {
            if (Convert.ToInt32(i) > maxi)
            {
                maxi = Convert.ToInt32(i);
            }
        }
        Console.WriteLine(neev + " legjobb jegye: " + maxi);

        int mini = 9999;
        foreach (string i in jeggy)
        {
            if (Convert.ToInt32(i) < mini)
            {
                mini = Convert.ToInt32(i);
            }
        }

        Console.WriteLine(neev + " legrosszabb jegye: " + mini);


        //-----------------------------------------------------------------------------------

        Console.WriteLine("Kerek egy szót: ");
        string szo = Console.ReadLine();

        if (igen(szo))
        {
            Console.WriteLine($"{szo} egy palindrom.");
        }
        else
        {
            Console.WriteLine($"{szo} nem egy palindrom.");
        }

    }
    static bool igen(string szo)
    {      
        string tisztitottSzo = szo.ToLower();
        string visszaforditottSzo = Fordit(tisztitottSzo);
        return tisztitottSzo == visszaforditottSzo;
    }

    static string Fordit(string szo)
    {
        char[] charArray = szo.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
