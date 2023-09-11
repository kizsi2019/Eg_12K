using System.Collections.Generic;
using System.Windows.Forms;

namespace nyami_menuztetes
{
    //A Model osztályhoz tartozó Interfész
    internal interface IModel
    {
        List<Rendelesek> GiveData();

        string DataChange(int price1, int price2, bool elvitel);

        void Frissites();

        Menu GetNapiMenu();

        void Rendeles(string price, bool elvitel);

        Rendelesek GetLine(int index);

        void ClearAll(ListBox elemek);

        void Delete(int index);
    }
}
