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

namespace CRUD
{
    public partial class Form1 : Form
    {
        string server = "localhost";
        string uid = "root";
        string password = "";
        string database = "oscar";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string createTable = "create table test_table(id int, name varchar(50), fname varchar(50))";
            MySqlCommand cmd = new MySqlCommand(createTable,con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string insertData = "insert into test_table(id, name, fname) values ("+tb1.Text+",'"+tb2.Text+"','"+tb3.Text+"' )";
            MySqlCommand cmd = new MySqlCommand(insertData, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "select * from test_table";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string updateTable = "update test_table set name='Gyula' where id = 1";
            MySqlCommand cmd = new MySqlCommand(updateTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string delete = "Delete from test_table where id = 3";
            MySqlCommand cmd = new MySqlCommand(delete, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "select film.ev,film.cim from film where nyert order by ev;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT film.ev FROM film GROUP BY film.ev HAVING COUNT(id)>=10; ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT film.cim FROM film WHERE film.ev BETWEEN '1939' AND '1945' AND film.bemutato BETWEEN '1939-1-1' AND '1945-12-31'; ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT film.cim FROM film WHERE YEAR(film.bemutato)-film.ev>=10 AND film.nyert; ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT keszito.nev, MAX(film.ev)-MIN(film.ev) AS eltelt, COUNT(film.id) AS db FROM film, keszito, kapcsolat WHERE film.id=kapcsolat.filmid AND keszito.id=kapcsolat.keszitoid AND keszito.producer GROUP BY keszito.nev HAVING COUNT(film.id)>1; ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT DISTINCT keszito.nev FROM keszito, kapcsolat WHERE keszito.id=kapcsolat.keszitoid AND kapcsolat.filmid IN    (SELECT kapcsolat.filmid      FROM kapcsolat, keszito     WHERE kapcsolat.keszitoid=keszito.id      AND keszito.nev='Clint Eastwood')AND nev<>'Clint Eastwood'; ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT keszito.nev FROM keszito WHERE keszito.id NOT IN (SELECT kapcsolat.keszitoid FROM kapcsolat, film WHERE kapcsolat.filmid=film.id AND film.bemutato IS NOT NULL)   AND keszito.producer; ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }
    }
}
