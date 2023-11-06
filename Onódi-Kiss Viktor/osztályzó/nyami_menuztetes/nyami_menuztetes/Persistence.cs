using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nyami_menuztetes
{

    internal class Persistence : IPersistence
    {
        #region Globális változók
        
        //Az idcount tartalmazza az utolsó számot az egyedi azonosítókban, ez alapján határozzuk meg a következő kioszthatót
        private int idcount = 0;

        //A myRend lista fogja tartalmazni az eddig leadott rendeléseket
        public List<Rendelesek> myRend = new List<Rendelesek>();

        //A connectionstring tartalmazza az adatbázishoz csatlakozáshoz szükséges konfigurációt
        private string connectionstring = "";
        
        #endregion

        //A Persistence osztály konstruktőre
        public Persistence()
        {
            CreateDatabase();
            CreateTable1();
            CreateTable2();
            ReadFromFile();
            ReadRend();
        }

        #region Adatbázis építés

        //A CreateDatabase függvény hozza létre az adatbázisunkat, ha az még nem létezik
        private void CreateDatabase()
        {
            if (!System.IO.File.Exists("data.sqlite"))
            {
                SQLiteConnection.CreateFile("data.sqlite");
            }
            connectionstring = "Data Source=data.sqlite;Version=3;";
        }

        //A CreateTable1 függvény hozza létre a napimenük lehetséges összetevőinek tábláját
        private void CreateTable1()
        {
            SQLiteConnection conn = new SQLiteConnection(connectionstring);

            conn.Open();
            string query = "create table if not exists items (id varchar(20) , name varchar(20), cat varchar(20), price int)";
            SQLiteCommand command = new SQLiteCommand(query, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        //A CreateTable2 függvény hozza létra a rendeléseket tartalmazó táblát
        private void CreateTable2()
        {

            SQLiteConnection conn = new SQLiteConnection(connectionstring);

            conn.Open();
            string query = "create table if not exists rendelesek (id int , price int, date varchar(20), elvitel int)";
            SQLiteCommand command = new SQLiteCommand(query, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        #endregion

        #region Rendelés Eventek

        //Ezzel a methódussal olvassuk be a rendeléseket az adatbázisból
        public void ReadRend()
        {

            SQLiteConnection conn = new SQLiteConnection(connectionstring);

            string query = "select * from Rendelesek";

            conn.Open();
            SQLiteCommand command = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = command.ExecuteReader();
            myRend.Clear();
            while (reader.Read())
            {
                myRend.Add(new Rendelesek
                (
                    reader.GetDecimal(0),
                    reader.GetDecimal(1),
                    reader.GetString(2),
                    reader.GetDecimal(3)
                 ));
            }
            idcount = myRend.Count > 0 ? myRend[myRend.Count - 1].id : 0;
            reader.Close();
            conn.Close();

        }

        //Ezzel a metódussal adunk hozzá elemet a rendelesek táblához
        public void AddElem(int price, DateTime date, bool elvitel)
        {
            SQLiteConnection conn = new SQLiteConnection(connectionstring);

            conn.Open();
            SQLiteCommand command = new SQLiteCommand(conn);
            command.CommandText = "INSERT INTO Rendelesek(id, price, date, elvitel) VALUES(@id, @price, @date, @elvitel)";
            command.Parameters.AddWithValue("@id", ++idcount);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@date", Convert.ToString(date));
            command.Parameters.AddWithValue("@elvitel", Convert.ToInt32(elvitel));
            command.ExecuteNonQuery();
            conn.Close();
        }

        //Ezzel a metódussal törlünk elemet, a megadott azonosító alapján, a rendelesek táblából
        public void DeleteElem(int id)
        {
            SQLiteConnection conn = new SQLiteConnection(connectionstring);

            conn.Open();
            Rendelesek searched = myRend.Where(x => x.id == id).First();
            myRend.Remove(searched);
            string query = $"DELETE FROM Rendelesek WHERE id = {id};";

            SQLiteCommand command = new SQLiteCommand(query, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        //Ezzel a metódussal törlünk ki minden elemet a rendelesek táblából
        public void ClearAll()
        {
            idcount = 0;
            myRend.Clear();
            SQLiteConnection conn = new SQLiteConnection(connectionstring);
            conn.Open();
            string query = "DROP TABLE Rendelesek";
            SQLiteCommand command = new SQLiteCommand(query, conn);
            command.ExecuteNonQuery();
            conn.Close();
            CreateTable2();
        }
        #endregion

        #region Napimenü

        //A GetData metódussal kérjük le a napimenükhöz tartozó választék listáját 
        public List<Items> GetData()
        {
            List<Items> myData = new List<Items>();

            SQLiteConnection conn = new SQLiteConnection(connectionstring);

            string query = "select * from items";

            conn.Open();
            SQLiteCommand command = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                myData.Add(new Items
                (
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetDecimal(3)
                 ));
            }
            reader.Close();
            conn.Close();

            return myData;
        }

        //A ReadFromFile függvénnyel olvassuk be a napimenük lehetséges összetevőit tartalmazó txt fájl tartalmát
        private void ReadFromFile()
        {
            if (!System.IO.File.Exists("../../../forrasok/forras.txt"))
            {
                MessageBox.Show("A 'forras.txt' nem található!");
                return;
            }

            List<Items> myData = System.IO.File.ReadAllLines("../../../forrasok/forras.txt")
                .Skip(1)
                .Select(x => x.Split(';'))
                .Select(x => new Items(
                x[0],
                x[1],
                x[2],
                x[3]))
                .ToList();

            SQLiteConnection conn = new SQLiteConnection(connectionstring);
            SQLiteCommand command = new SQLiteCommand(conn);
            conn.Open();

            foreach(Items item in myData)
            {
                command.CommandText = "INSERT INTO items(id, name, cat, price) VALUES(@id, @name, @cat, @price)";
                command.Parameters.AddWithValue("@id",item.id);
                command.Parameters.AddWithValue("@name", item.name);
                command.Parameters.AddWithValue("@cat", item.cat);
                command.Parameters.AddWithValue("@price", item.price);
                command.ExecuteNonQuery();
            }
            conn.Close();

        }

        #endregion

    }


}
