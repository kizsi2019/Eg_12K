using System;

namespace nyami_menuztetes
{
    //Az adott napra random kisorsolt elemekből álló menüt tartalmazó struct
    public struct Menu
    {
        //A teljes ár
        public int pricetelj { get; set; }

        //A zóna ár (66.6%)
        public double pricezona { get; set; }

        //A leves neve
        public string name1 { get; set; }

        //A főétel neve
        public string name2 { get; set; }

        //A Menu struct konstruktőre
        public Menu(int _price1, int _price2, string _name1, string _name2)
        {
            pricetelj = _price1 + _price2;
            pricezona = Math.Round(Convert.ToDouble(pricetelj) * (2.0 / 3.0));
            name1 = _name1;
            name2 = _name2;
        }
    }
}
