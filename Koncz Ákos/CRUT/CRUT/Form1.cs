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

            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";

            button1.BackColor = Color.Red;
            button2.BackColor = Color.Blue;
            button3.BackColor = Color.Bisque;
            button4.BackColor = Color.BlanchedAlmond;
            button6.BackColor = Color.DarkOliveGreen;
            button7.BackColor = Color.Cyan;
            button8.BackColor = Color.MediumPurple;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;

            MySqlConnection con = new MySqlConnection(conString);
            con.Open();

            string insertTable = "insert into text_table(id, name, fname) values (" + tb1.Text + ", '" + tb2.Text + "', '" + tb3.Text + "')";
            MySqlCommand cmd = new MySqlCommand(insertTable, con);

            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;

            MySqlConnection con = new MySqlConnection(conString);
            con.Open();

            string createTable = "create table text_table(id int, name varchar(50), fname varchar(50));";
            MySqlCommand cmd = new MySqlCommand(createTable, con);

            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;

            MySqlConnection con = new MySqlConnection(conString);
            con.Open();

            string sql = "SELECT * FROM text_table";
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

            string updateTable = "UPDATE text_table SET name = 'Gyula' WHERE id = 1";
            MySqlCommand cmd = new MySqlCommand(updateTable, con);

            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;

            MySqlConnection con = new MySqlConnection(conString);
            con.Open();

            string deleteTable = "DELETE FROM text_table WHERE id = 1";
            MySqlCommand cmd = new MySqlCommand(deleteTable, con);

            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;

            MySqlConnection con = new MySqlConnection(conString);
            con.Open();

            string sql = "SELECT * FROM oscar";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(reader);

            dataGridView1.DataSource = dt;
        }
    }
}
