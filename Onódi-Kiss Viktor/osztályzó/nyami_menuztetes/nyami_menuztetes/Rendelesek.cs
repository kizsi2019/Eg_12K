using System;

namespace nyami_menuztetes
{
    public struct Rendelesek
    {
        //Az id tartalmazza a rendelés egyedi azonosítóját
        public int id { get; set; }

        //A price tartalmazza a rendelés árát
        public int price { get; set; }

        //A date menti el a rendelés leadásának idejét
        public DateTime date { get; set; }

        //Az elvitel bool tartalmazza azt, hogy a felhasználó elvitelre kérte-e a rendelését vagy sem
        public bool elvitel { get; set; }

        //A Rendelesek konstruktőre, ami az adatbázisból való beolvasáskor kerül meghívásra
        public Rendelesek(decimal _id, decimal _price, string _date, decimal _elvitel)
        {
            id = Convert.ToInt32(_id);
            price = Convert.ToInt32(_price);
            date = Convert.ToDateTime(_date);
            elvitel = Convert.ToBoolean(_elvitel);
        }
    }
}
