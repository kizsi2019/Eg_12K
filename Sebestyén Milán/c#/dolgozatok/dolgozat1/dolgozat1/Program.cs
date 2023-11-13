using System;
using System.Diagnostics.Tracing;
using System.Threading.Tasks.Dataflow;
using System.Xml.Schema;

class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("nevet kerek: ");
        string neev = Console.ReadLine();
        bool ha=false;
        int jo = 0;

        Console.WriteLine("jegyeket kerek vesszovel elvalasztva");
        string jeggyy = Console.ReadLine();
        string[] jeggy = jeggyy.Split(',');
        
       
        int a = 0;
        foreach (string item in jeggy)
        {
            a += Convert.ToInt32(item);
        }
        double avvg =Convert.ToDouble(a) / jeggy.Length;
        double avg = Math.Round(avvg,2);
        Console.WriteLine(neev+" átlaga: "+avg);



        int maxi = 0;
        foreach (string i in jeggy)
        {
            if (Convert.ToInt32(i) > maxi)
            {
                maxi = Convert.ToInt32(i);
            }
        }
        Console.WriteLine(neev+" legjobb jegye: "+maxi);

        int mini = 9999;
        foreach (string i in jeggy)
        {
            if (Convert.ToInt32(i) < mini)
            {
                maxi = Convert.ToInt32(i);
            }
        }
        Console.WriteLine(neev + " legrosszabb jegye: " + maxi);

        //-----------------------------------------------------------------------------------

        Console.WriteLine("kerek egy szot");
        string asdf=Console.ReadLine();
        
        Stack<char> stack = new Stack<char>();
        List<char> list = new List<char>();

        foreach (char i in asdf)
        {
            
            
            stack.Push(i);
            list.Add(i);
            
        }
  
        bool joo = true;
        for (int i = 0; i < stack.Count; i++)
        {

        }







    }
}