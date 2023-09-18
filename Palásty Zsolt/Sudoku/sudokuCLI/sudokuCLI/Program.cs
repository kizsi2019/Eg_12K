/* 1) Készítsen konzolos alkalmazást a következő feladatok megoldására, amelynek prorektjét sudokuCLI néven mentse el!*/
/* 2) A forráskódban a meglévő osztály elé illessze be az Osztaly.java avagy Osztaly.cs forrásállományból a Feladvany 
osztályt definiáló kódrészletet! A beillesztett osztály tetszés szerint bővíthető további tagokkal!*/
namespace suddokuCLI
{
    class program
    {
        struct feladvany
        {
            public int row { get; set; }
        }
            static void Main(string[] args)
            {
                Import();
                Console.WriteLine("3.Feladat");
                Console.WriteLine();
            }
            /* 3) Olvassa be a feladvanyok.txt állományban lévő adatokat és tárolja el egy olyan adatszerkezetben, ami a további feladatok 
            megoldására alkalmas!  Határozza meg és írja ki a képernyőre a minta szerint, hogy hány feladvány található a forrásállományban!*/


            List<feladvany> lista = new List<feladvany>();
            static void Import()
            {
                System.IO.StreamReader read = new System.IO.StreamReader("feladvanyok.txt");
                while (!read.EndOfStream)
                {

                }
            }


            /* 4) Kérjen be a felhasználótól egy 4...9 intervallumba eső (4≤x≤9) egész számot! A beolvasást 
            addig ismételje, amíg a megfelelő értékhatárból érkező számot nem kapjuk! Határozza meg, 
            és írja a képernyőre, hogy ebből a méretből hány feladvány található a forrásállományban!*/




            /* 5) Válasszon ki véletlenszerűen egy feladványt, amely az előző feladatban bekért méretű! 
            A kiválasztott feladványt jelenítse meg a képernyőn a minta szerint! Ha nem sikerült 
            véletlenszerű feladványt kiválasztani, akkor dolgozzon a legelső beolvasott feladvánnyal!*/




            /* 6) Határozza meg és írja a képernyőre a kiválasztott feladvány kitöltöttségét %-os formában 
            a minta szerint! A kitöltöttségen a kitöltött mezők arányát értjük az összes mező számához 
            viszonyítva! A százalékos értéket egész számra kerekítve jelenítse meg!*/




            /* 7) A Feladvany osztály megfelelő metódusát felhasználva jelenítse meg a kiválasztott 
            feladványt a konzolon!*/




            /* 8) Válogassa ki és írja ki fájlba az adott méretű feladványokat! Ha például a felhasználó a 4-es 
            méretet adta meg, akkor a kimeneten egy sudoku4.txt állományba kerüljenek a 4x4-es 
            méretű feladványok! Az állományban soronként egy feladvány kerüljön!*/




            /* 9) Készítsen grafikus alkalmazást a következő feladatok megoldására, amelynek projektjét 
            sudokuGUI néven mentse el!*/



        
    }
}



