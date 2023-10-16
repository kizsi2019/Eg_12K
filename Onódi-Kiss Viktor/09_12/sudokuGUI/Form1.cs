using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudokuGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 540;
            this.Height = 210;
            this.Text = "Sudoku-ellenörző";

            int count = 4;

            Label lbl = new Label();
            lbl.Text = "Új feladvány mérete: ";

            lbl.Location = new System.Drawing.Point(10, 20);
            lbl.Name = "label";
            lbl.Size = new System.Drawing.Size(110, 22);

            TextBox bevitel = new TextBox();

            bevitel.Location = new System.Drawing.Point(140, 20);
            bevitel.Name = "bevitel";
            bevitel.Size = new System.Drawing.Size(120, 22);

            bevitel.Text = count.ToString();

            Button minus = new Button();

            minus.Text = "-";
            minus.Location = new System.Drawing.Point(120, 20);
            minus.Name = "minus";
            minus.Size = new System.Drawing.Size(20, 20);

            Button plus = new Button();

            plus.Text = "+";
            plus.Location = new System.Drawing.Point(260, 20);
            plus.Name = "plus";
            plus.Size = new System.Drawing.Size(20, 20);

            Label lbl2 = new Label();

            lbl2.Text = "Kezdőállapot";
            lbl2.Location = new System.Drawing.Point(10, 80);
            lbl2.Name = "kezdo";

            TextBox kezdo = new TextBox();

            kezdo.Location = new System.Drawing.Point(10, 110);
            kezdo.Size = new System.Drawing.Size(500, 20);

            Label hossz = new Label();
            hossz.Text = "Hossz";
            hossz.Location = new System.Drawing.Point(10, 140);
            hossz.Size = new System.Drawing.Size(50, 20);

            Label hosszt = new Label();
            hosszt.Text = "0";
            hosszt.Location = new System.Drawing.Point(60, 140);

            Button ellenorzes = new Button();
            ellenorzes.Text = "Ellenőrzés";
            ellenorzes.Location = new System.Drawing.Point(440, 140);


            kezdo.TextChanged += (s, e) =>
            {
                hosszt.Text = kezdo.Text.Count().ToString();
            };

            ellenorzes.Click += (s, e) =>
            {
                string text = "";

                int x = count * count;

                if (kezdo.Text.Count() == x)
                {
                    text = "A feladvány megfelelő hosszúságú!";
                }
                else if(kezdo.Text.Count() < Convert.ToInt32(bevitel.Text) * Convert.ToInt32(bevitel.Text))
                {
                    text = $"A feladvány rövid, kell még {x - kezdo.Text.Count()} számjegy!";
                }
                else
                {
                    text = $"A feladvány hosszú, törlendő {kezdo.Text.Count() -x} számjegy!";
                }
                MessageBox.Show(text);
            };

            plus.Click += (s, e) =>
            {
                if(count < 9)
                {
                    count++;
                }
                bevitel.Text = count.ToString();
            };
            minus.Click += (s, e) =>
            {
                if (count > 4)
                {
                    count--;
                }
                bevitel.Text = count.ToString();
            };

            this.Controls.Add(bevitel);
            this.Controls.Add(lbl);
            this.Controls.Add(minus);
            this.Controls.Add(plus);

            this.Controls.Add(lbl2);
            this.Controls.Add(kezdo);
            this.Controls.Add(hossz);
            this.Controls.Add(hosszt);
            this.Controls.Add(ellenorzes);

        }

    }
}
