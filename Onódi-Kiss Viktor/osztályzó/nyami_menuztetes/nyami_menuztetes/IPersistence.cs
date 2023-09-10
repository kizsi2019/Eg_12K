using System;
using System.Collections.Generic;

namespace nyami_menuztetes
{
    //A Persistence osztályhoz tartozó interfész
    internal interface IPersistence
    {
        #region Rendelés Eventek
        void ReadRend();

        void AddElem(int price, DateTime date, bool elvitel);

        void DeleteElem(int id);

        void ClearAll();
        #endregion

        #region Napimenü
        List<Items> GetData();

        #endregion
    }
}
