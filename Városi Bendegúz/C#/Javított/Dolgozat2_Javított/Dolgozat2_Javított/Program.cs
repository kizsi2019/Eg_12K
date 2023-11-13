using System;

namespace Dolgozat2_Javított
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek szépen egy szöveget");
            string text = Console.ReadLine();

            bool palindrom = IsPalindrom(text);

            if (palindrom)
            {
                Console.WriteLine("A szöveg palindrom!");
            }
            else
            {
                Console.WriteLine("A szöveg nem palindrom!");
            }
            Console.ReadKey();
        }

        static bool IsPalindrom(string text)
        {
            int length = text.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (text[i] != text[length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
