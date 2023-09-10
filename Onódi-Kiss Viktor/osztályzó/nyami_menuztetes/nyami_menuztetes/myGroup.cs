using System;
using System.Drawing;
using System.Windows.Forms;

namespace nyami_menuztetes
{
    //Az Inner osztály szolgál az adott groupon belüli adag kiválasztási lehetőségek felépítéséért
    internal class Inner : Panel
    {
        //A teljes árhoz tartozó rádiógomb és ár
        public RadioButton radio1 = new RadioButton();
        private string price1;

        //A zóna árhoz tartozó rádiógomb és ár
        public RadioButton radio2 = new RadioButton();
        private string price2;

        //Ideiglenes konstruktőr, az osztály üres inicializálása érdekében
        public Inner()
        {
            //Temp
        }

        //Az Inner valódi konstruktőre, ami felépíti az Inner osztályt a lapon
        public Inner(string _price1, string _price2)
        {
            price1 = _price1;
            price2 = _price2;
            this.Size = new System.Drawing.Size(150, 80);
            this.BorderStyle = BorderStyle.FixedSingle;

            radio1.Location = new System.Drawing.Point(20, 10);
            radio1.Text = "Teljes".PadRight(11) + price1 + " Ft";
            radio1.Font = new System.Drawing.Font("Arial", 10);
            radio1.AutoSize = true;
            radio1.TabStop = false;
            radio1.Click += (s, e) =>
            {
                radio1.Enabled = false;
                this.Parent.Parent.Parent.Parent.Focus();
                radio1.Enabled = true;
            };
            radio1.CheckedChanged += (s, e) =>
            {
                radio1.TabStop = false;
                radio2.TabStop = false;
            };

            radio2.Location = new System.Drawing.Point(20, 50);
            radio2.Text = "Zóna".PadRight(10) + price2 + " Ft";
            radio2.Font = new System.Drawing.Font("Arial", 10);
            radio2.AutoSize = true;
            radio2.TabStop = false;
            radio2.Click += (s, e) =>
            {
                radio2.Enabled = false;
                this.Parent.Parent.Parent.Parent.Focus();
                radio2.Enabled = true;
            };
            radio2.CheckedChanged += (s, e) =>
            {
                radio1.TabStop = false;
                radio2.TabStop = false;
            };

            this.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            this.Controls.Add(radio1);
            this.Controls.Add(radio2);
        }

        //A teljes ár lekérdezésére szolgáló metódus
        public int GetPrice1()
        {
            return Convert.ToInt32(price1);
        }

        //A zóna ár lekérdezésére szolgáló metódus
        public int GetPrice2()
        {
            return Convert.ToInt32(price2);
        }

        //A OneChoosen metódus ami visszaadja Bool-ként, hogy akármelyik rádiógomb ki van-e választva
        public bool OneChoosen()
        {
            return radio1.Checked || radio2.Checked;
        }

        //A Choosen metódus ami visszaadja a kiválasztott rádiógombhoz tartozó árat
        public string Choosen()
        {
            if (radio1.Checked)
            {
                return price1;
            }
            if (radio2.Checked)
            {
                return price2;
            }
            return "";
        }


    }

    internal class MyGroup : Panel
    {
        private Label title = new Label();
        private Label leves = new Label();
        public Label levestxt = new Label();
        private Label foetel = new Label();
        public Label foeteltxt = new Label();
        public NumericUpDown count = new NumericUpDown();
        public TextBox price = new TextBox();
        public Inner myInner = new Inner();

        //A MyGroup üres konstrukőre
        public MyGroup()
        {
            //Generikus konstruktőr
        }

        //A MyGroup valódi konstrukőre, ami felépíti a MyGroup osztályt a Form-on
        public MyGroup(int Y, string menu, string price1, string price2, string _leves, string _foetel)
        {
            this.Size = new System.Drawing.Size(520, 110);
            this.Location = new System.Drawing.Point(10, Y);
            this.BorderStyle = BorderStyle.FixedSingle;
            title.Text = menu;
            title.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Underline);
            title.Location = new System.Drawing.Point(10, 5);

            leves.Text = $"Leves:";
            leves.AutoSize = true;
            leves.Location = new System.Drawing.Point(20, 35);
            leves.Font = new System.Drawing.Font("Arial", 10);
            leves.BackColor = Color.Transparent;

            levestxt.Text = _leves;
            levestxt.TextAlign = ContentAlignment.TopRight;
            levestxt.AutoSize = false;
            levestxt.Location = new System.Drawing.Point(70, 35);
            levestxt.Font = new System.Drawing.Font("Arial", 10);
            levestxt.Size = new Size(170, 35);
            levestxt.BackColor = Color.Transparent;

            foetel.Text = $"Főétel:";
            foetel.AutoSize = true;
            foetel.Location = new System.Drawing.Point(20, 70);
            foetel.Font = new System.Drawing.Font("Arial", 10);
            foetel.BackColor = Color.Transparent;

            foeteltxt.Text = _foetel;
            foeteltxt.TextAlign = ContentAlignment.TopRight;
            foeteltxt.AutoSize = false;
            foeteltxt.Location = new System.Drawing.Point(70, 70);
            foeteltxt.Font = new System.Drawing.Font("Arial", 10);
            foeteltxt.Size = new Size(170, 35);
            foeteltxt.BackColor = Color.Transparent;


            myInner = new Inner(price1, price2);
            myInner.Location = new System.Drawing.Point(250, 20);
            myInner.radio1.CheckedChanged += (s, e) => ValueChange();
            myInner.radio2.CheckedChanged += (s, e) => ValueChange();

            count.Maximum = 100;
            count.Minimum = 0;
            count.Location = new System.Drawing.Point(420, 20);
            count.Size = new System.Drawing.Size(40, 20);
            count.TabStop = false;
            count.ValueChanged += (s, e) => ValueChange();

            price.Location = new System.Drawing.Point(410, this.Size.Height - 35);
            price.TabStop = false;
            price.Enabled = false;

            this.Controls.Add(title);
            this.Controls.Add(leves);
            this.Controls.Add(levestxt);
            this.Controls.Add(foetel);
            this.Controls.Add(foeteltxt);
            this.Controls.Add(count);
            this.Controls.Add(price);
            this.Controls.Add(myInner);

        }

        //A SetCountClick metódus kikapcsolja a számoló control-t, ha azt kattintás éri
        public void SetCountClick(Form form)
        {
            count.Click += (s, e) =>
            {
                count.Enabled = false;
                form.Focus();
                count.Enabled = true;
            };
            count.DoubleClick += (s, e) =>
            {
                count.Enabled = false;
                form.Focus();
                count.Enabled = true;
            };
        }

        //A ValueChange metódus változtatja a MyGroupon belül található árat tartalmazó szövegdobozt
        private void ValueChange()
        {
            if (count.Value > 0 && myInner.OneChoosen())
            {
                price.Text = (Convert.ToInt32(myInner.Choosen()) * count.Value).ToString();
            }
            else
            {
                price.Text = "0";
            }
        }

        //A ToPay metódusa visszaadja a fizetendő összeget Integer formájában
        public int ToPay()
        {
            if (price.Text == "")
            {
                return 0;
            }
            return Convert.ToInt32(price.Text);
        }

    }
}
