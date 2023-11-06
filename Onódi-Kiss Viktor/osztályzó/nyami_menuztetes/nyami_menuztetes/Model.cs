using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace nyami_menuztetes
{
    internal class Model : IModel
    {
        #region Globális változók

        //A Persistence osztály változójának inicializálása
        static private Persistence dataset = new Persistence();

        //A naopi menü választékának listája
        static private List<Items> myData = new List<Items>();

        #endregion

        //A Model osztály konstruktőre
        public Model()
        {
            myData = dataset.GetData();
        }

        //GiveData metódus szolgál a Rendeléseket tartalmazó lista továbbítására
        public List<Rendelesek> GiveData()
        {
            return dataset.myRend;
        }

        //A DataChange metódus adja vissza a menü oldalon található összesített ár értékét
        public string DataChange(int price1, int price2, bool elvitel)
        {
            if (elvitel)
            {
                return (price1 + price2 + 200).ToString();
            }
            else
            {
                return (price1 + price2).ToString();
            }
        }

        //A Frissites metódus frissíti az adatokat az adatbázisban
        public void Frissites()
        {
            dataset.ReadRend();
            myData = dataset.GetData();
        }

        //A GetNapiMenu metódus kiválaszt egy random levest és egy random főételt a lehetséges elemek listájából
        public Menu GetNapiMenu()
        {

            List<Items> levesek = myData.Where(x => x.cat == "leves").ToList();
            List<Items> foetelek = myData.Where(x => x.cat == "főétel").ToList();
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            Items choosenlev = levesek[rand.Next(0, levesek.Count)];
            Items choosenFoetel = foetelek[rand.Next(0, foetelek.Count)];

            return new Menu(choosenlev.price, choosenFoetel.price, choosenlev.name, choosenFoetel.name);
        }

        //A Rendeles metódus foglalkozik a felugró ablak dobásával illetve az ahhoz tartozó logikával
        public void Rendeles(string priceTxt, bool elvitel)
        {
            if (priceTxt == "" || priceTxt == "0")
            {
                MessageBox.Show("A rendeléshez ki kell választanod tételt!");
            }
            else if (Convert.ToInt32(priceTxt) <= 200 && Convert.ToInt32(priceTxt) > 0)
            {
                MessageBox.Show("Ki kell választanod tételt is a rendeléshez!");
            }
            else
            {
                int price = Convert.ToInt32(priceTxt);
                MessageBox.Show("Sikeres rendelés!");
                DateTime date = DateTime.Now;
                dataset.AddElem(price, date, elvitel);
            }
        }

        //A GetLine metódus visszaadja az adatbázis kijelölt indexű elemét
        public Rendelesek GetLine(int index)
        {
            return dataset.myRend[index];
        }

        //A ClearAll metódus törli a rendelések oldalon található lista doboz tartalmát és az adatbázis rendeles tábláját
        public void ClearAll(ListBox elemek)
        {
            if (elemek.Items.Count < 1)
            {
                MessageBox.Show("A lista már üres!");
            }
            else
            {
                elemek.Items.Clear();
                dataset.ClearAll();
                MessageBox.Show("Sikeres törlés!");
            }
        }

        //A Delete metódus kitörli a beviteli értékként kapott indexen található elemet
        public void Delete(int index)
        {
            dataset.DeleteElem(index);
        }

    }
}
