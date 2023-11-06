using System;

namespace nyami_menuztetes
{
    //A lehetséges menü elemekt tartalmazó struct
    public struct Items
    {
        //Az elem egyedi azonosítója
        public string id { get; set; }

        //Az elem neve
        public string name { get; set; }

        //Az elem kategóriája (leves/főétel)
        public string cat { get; set; }

        //Az elem ára
        public int price { get; set; }

        //Az első konstruktőr az adatbázisból való beolvasáshoz használható
        public Items(string _id, string _name, string _cat, decimal _price)
        {
            id = _id;
            name = _name;
            cat = _cat;
            price = Convert.ToInt32(_price);
        }

        //A második konstruktőr a txt fájlból való beolvasáshoz használható
        public Items(string _id, string _name, string _cat, string _price)
        {
            id = _id;
            name = _name;
            cat = _cat;
            price = Convert.ToInt32(_price);
        }
    }
}
