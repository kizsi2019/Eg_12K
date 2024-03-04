using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using MySql.Data.MySqlClient;

namespace CRUT
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

        private void button2_Click(object sender, EventArgs e)
        {
            string conString = "server= " + server + ";uid= " + uid + ";pwd= " + password + ";database= " + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string insertTable = "insert into test_table(id, name, fname) values("+tb1.Text+", '"+tb2.Text+ "','"+tb3.Text+"')";
            string createTable = "create table test_table(id int, name varchar(50), fname varchar(50))";
            MySqlCommand cmd = new MySqlCommand(insertTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string conString = "server= " + server + ";uid= " + uid + ";pwd= " + password + ";database= " + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string createTable = "create table test_table(id int, name varchar(50), fname varchar(50))";
            MySqlCommand cmd = new MySqlCommand(createTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string conString = "server= " + server + ";uid= " + uid + ";pwd= " + password + ";database= " + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "select * from test_table";
            string createTable = "create table test_table(id int, name varchar(50), fname varchar(50))";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string conString = "server= " + server + ";uid= " + uid + ";pwd= " + password + ";database= " + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string updateTable = "Update test_table set name ='Gyula' where id =1";
            MySqlCommand cmd = new MySqlCommand(updateTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string conString = "server= " + server + ";uid= " + uid + ";pwd= " + password + ";database= " + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string deleteTable = "Delete from test_table where id = 3";
            MySqlCommand cmd = new MySqlCommand(deleteTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string conString = "server= " + server + ";uid= " + uid + ";pwd= " + password + ";database= " + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT film.ev, film.cim FROM film WHERE nyert ORDER BY ev;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string conString = "server= " + server + ";uid= " + uid + ";pwd= " + password + ";database= " + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT film.ev FROM film GROUP BY ev HAVING Count(id)>=10;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string conString = "server= " + server + ";uid= " + uid + ";pwd= " + password + ";database= " + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT film.cim    FROM film    WHERE ev BETWEEN 1939 And 1945 AND bemutato BETWEEN '1939-1-1' AND '1945-12-31'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void bnt5_Click(object sender, EventArgs e)
        {
            string conString = "server= " + server + ";uid= " + uid + ";pwd= " + password + ";database= " + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = " SELECT film.cim FROM film WHERE Year(bemutato)-ev >= 10      AND nyert;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string conString = "server= " + server + ";uid= " + uid + ";pwd= " + password + ";database= " + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT keszito.nev, MAX(film.ev)-MIN(film.ev) AS eltelt, COUNT(film.id) AS db    FROM film, kapcsolat, keszito    WHERE film.id=kapcsolat.filmid AND kapcsolat.keszitoid=keszito.id      AND keszito.producer    GROUP BY keszito.nev    HAVING COUNT(film.id)>1;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void bnt7_Click(object sender, EventArgs e)
        {
            string conString = "server= " + server + ";uid= " + uid + ";pwd= " + password + ";database= " + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT DISTINCT keszito.nev FROM keszito, kapcsolat    WHERE keszito.id=kapcsolat.keszitoid AND kapcsolat.filmid IN        (SELECT kapcsolat.filmid FROM kapcsolat, keszito WHERE keszito.id=kapcsolat.keszitoid AND nev= Clint Eastwood)  AND nev<>Clint Eastwood;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string conString = "server= " + server + ";uid= " + uid + ";pwd= " + password + ";database= " + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT keszito.nev FROM keszito WHERE keszito.id NOT I(SELECT kapcsolat.keszitoid FROM kapcsolat, film WHERE kapcsolat.filmid = film.id     AND film.bemutato IS NOT NULL) AND keszito.producer;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }
    }
}
