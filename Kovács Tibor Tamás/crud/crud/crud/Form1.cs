using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace crud
{
    public partial class Oscar : Form
    {
        string server = "localhost";
        string uid = "root";
        string password = "";
        string database = "crud_muveletek";
        public Oscar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "select * from text_table";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string createTable = "create table text_table(id int, name varchar(50), fname varchar(50))";
            MySqlCommand cmd = new MySqlCommand(createTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string insertTable = "insert into text_table(id, name, fname) values ("+tb1.Text+", '"+tb2.Text+ "', '"+tb3.Text+"' )";
            MySqlCommand cmd = new MySqlCommand(insertTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string updateTable = "update text_table set name = 'Gyula' where id = 1";
            MySqlCommand cmd = new MySqlCommand(updateTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string deleteTable = "delete from text_table where id = 3";
            MySqlCommand cmd = new MySqlCommand(deleteTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "select film.ev, film.cim from film where nyert order by ev";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataGridView1.DataSource = dataTable;
            dataTable.Load(reader);
                
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql2 = "SELECT keszito.nev FROM keszito WHERE keszito.id NOT IN (SELECT kapcsolat.keszitoid FROM kapcsolat, film WHERE kapcsolat.filmid=film.id AND film.bemutato IS NOT NULL)    AND keszito.producer;";
            MySqlCommand cmd = new MySqlCommand(sql2, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataGridView1.DataSource = dataTable;
            dataTable.Load(reader);
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql2 = "SELECT film.ev FROM film GROUP BY film.ev HAVING COUNT(id)>=10;";
            MySqlCommand cmd = new MySqlCommand(sql2, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataGridView1.DataSource = dataTable;
            dataTable.Load(reader);
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql3 = "SELECT film.cim FROM film WHERE film.ev BETWEEN 1939 AND 1945 AND film.bemutato BETWEEN 1939-1-1 AND 1945-12-31;";
            MySqlCommand cmd = new MySqlCommand(sql3, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataGridView1.DataSource = dataTable;
            dataTable.Load(reader);
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql4 = "SELECT film.cim FROM film WHERE YEAR(film.bemutato)-film.ev>=10 AND film.nyert;";
            MySqlCommand cmd = new MySqlCommand(sql4, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataGridView1.DataSource = dataTable;
            dataTable.Load(reader);
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql4 = "SELECT keszito.nev, MAX(film.ev)-MIN(film.ev) AS eltelt, COUNT(film.id) AS db FROM film, keszito, kapcsolat WHERE film.id=kapcsolat.filmid AND keszito.id=kapcsolat.keszitoid AND keszito.producer GROUP BY keszito.nev HAVING COUNT(film.id)>1;";
            MySqlCommand cmd = new MySqlCommand(sql4, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataGridView1.DataSource = dataTable;
            dataTable.Load(reader);
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql4 = "SELECT DISTINCT keszito.nev FROM keszito, kapcsolat WHERE keszito.id=kapcsolat.keszitoid AND kapcsolat.filmid IN   (SELECT kapcsolat.filmid     FROM kapcsolat, keszito      WHERE kapcsolat.keszitoid=keszito.id     AND keszito.nev= Clint Eastwood) AND nev<> Clint Eastwood;";
            MySqlCommand cmd = new MySqlCommand(sql4, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataGridView1.DataSource = dataTable;
            dataTable.Load(reader);
        }
    }
}
