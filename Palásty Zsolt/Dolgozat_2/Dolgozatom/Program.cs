using System;
namespace Dolgozat_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy szöveget: ");
            string text = Console.ReadLine();

            Console.WriteLine(text);
            Console.WriteLine(Reverse(text));




            for(int i=0; i<text.Length; i++)
            {
                text.Split("");
                text_list.Add(text.Substring(i));
            }
            text_list_2 = Reverse(text_list);
            if(text_list == text_list_2)
            {
                Console.WriteLine("Ez a szüveg egy palindrom");
            }
            else
            {
                Console.WriteLine("Ez a szöveg nem egy palindrom :(");
            }
        }
        public List<string> text_list = new List<string>();
        public List<string> text_list_2 = new List<string>();
    }
}