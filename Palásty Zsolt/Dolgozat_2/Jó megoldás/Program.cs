using System;
namespace Dolgozat_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Írj egy programot, ami egy bekért szövegről megállapítja, hogy palindrom-e.
            Console.WriteLine("Kérem, adjon meg egy szöveget:");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine("A megadott szöveg palindrom.");
            }
            else
            {
                Console.WriteLine("A megadott szöveg nem palindrom.");
            }

            Console.ReadLine();
        }
        static bool IsPalindrome(string input)
        {
            // Tisztítjuk a szöveget: eltávolítjuk a szóközöket és kisbetűsítjük
            string cleanedInput = input.Replace(" ", "").ToLower();

            // Az összehasonlítás
            int length = cleanedInput.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (cleanedInput[i] != cleanedInput[length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}