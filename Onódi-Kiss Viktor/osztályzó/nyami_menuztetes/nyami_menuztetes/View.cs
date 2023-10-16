using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace nyami_menuztetes
{
    internal class View
    {
        #region Globális változók 
        //A Model osztály változójának inicializálása
        static Model mod = new Model();

        //A menü oldalon belüli alcsoportok inicializálása
        private MyGroup group1 = new MyGroup();
        private MyGroup group2 = new MyGroup();

        //A menü oldalon található összesített árat tartalmazó szövegdoboz
        private TextBox payUpt = new TextBox();

        //A menü oldalon található "elvitel" kijelölőnégyzet
        public CheckBox elvitel = new CheckBox();

        //A rendelések oldalon található lista doboz, amely az eddig leadott rendeléseket tartalmazza
        private ListBox elemek = new ListBox();

        //A rendelések oldalon található össz-bevételt tartalmazó szövegdoboz
        private TextBox bevetelIpt = new TextBox();

        #endregion

        //A konstruktőr, ami feltölti a rendelések oldalon található lista dobozt az eddig leadott rendelésekkel 
        public View()
        {
            FillList(elemek, bevetelIpt);
        }

        /*
         * A SetUp metódus bemeneti értékként kapja meg a Form-ot, amin az alap beállításokat elvégzi,
         * illetve meghívja a SetUpMenu és a SetUpRendelesek függvényeket
         */
        public void SetUp(Form myForm)
        {
            #region Elemek beállítása
            myForm.Text = "Nyami Menüztetés";
            myForm.Size = new Size(600, 420);
            myForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            myForm.MaximizeBox = false;
            myForm.StartPosition = FormStartPosition.CenterScreen;
            FlowLayoutPanel flp = new FlowLayoutPanel();
            flp.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            flp.Location = new Point(0, 0);

            LinkLabel nevjegy = new LinkLabel();
            LinkLabel kilepes = new LinkLabel();
            nevjegy.Text = "Névjegy";
            kilepes.Text = "Kilépés";
            nevjegy.LinkColor = System.Drawing.Color.Black;
            nevjegy.VisitedLinkColor = System.Drawing.Color.Black;
            nevjegy.Font = new Font("Arial", 11);
            nevjegy.Links.Clear();
            nevjegy.Links.Add(0, 1).Enabled = true;
            nevjegy.AutoSize = true;
            nevjegy.TabStop = false;
            kilepes.LinkColor = System.Drawing.Color.Black;
            kilepes.VisitedLinkColor = System.Drawing.Color.Black;
            kilepes.Font = new Font("Arial", 11);
            kilepes.Links.Clear();
            kilepes.Links.Add(0, 1).Enabled = true;
            kilepes.AutoSize = true;
            kilepes.TabStop = false;


            flp.Size = new Size(myForm.Size.Width, nevjegy.Size.Height);
            flp.Padding = new Padding(10, 2, 10, 2);


            TabControl tc = new TabControl();
            TabPage menu = new TabPage();
            TabPage rendelesek = new TabPage();
            tc.Location = new Point(12, 40);
            tc.SelectedIndex = 0;
            tc.Size = new System.Drawing.Size(558, 320);
            tc.TabStop = false;
            #endregion

            #region Eventek

            tc.Click += (s, e) =>
            {
                tc.Enabled = false;
                myForm.Focus();
                tc.Enabled = true;
            };
            myForm.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Tab)
                {
                    tc.Enabled = true;
                    if (tc.SelectedTab == menu)
                    {
                        tc.SelectTab(rendelesek);
                    }
                    else if (tc.SelectedTab == rendelesek)
                    {
                        tc.SelectTab(menu);
                    }
                    tc.Enabled = false;
                    myForm.Focus();
                    tc.Enabled = true;
                }
                if (e.KeyCode == Keys.N)
                {
                    Nevjegy aboutbox = new Nevjegy(myForm);
                    aboutbox.Show();
                }
                if (e.KeyCode == Keys.K)
                {
                    Application.Exit();
                }
            };
            nevjegy.Click += (s, e) =>
            {
                Nevjegy aboutbox = new Nevjegy(myForm);
                aboutbox.Show();
            };
            kilepes.Click += (s, e) => { Application.Exit(); };

            #endregion

            #region Alelemek beállítása

            if (!System.IO.File.Exists("../../../forrasok/menuztetes.jpg"))
            {
                MessageBox.Show("Hiba: a 'menuztetes.jpg' nem található!");
                return;
            }

            SetUpMenu(myForm, menu);
            SetUpRendelesek(myForm, rendelesek);

            #endregion

            #region Elemek hozzáadása
            myForm.Controls.Add(tc);
            tc.Controls.Add(menu);
            tc.Controls.Add(rendelesek);
            flp.Controls.Add(nevjegy);
            flp.Controls.Add(kilepes);
            myForm.Controls.Add(flp);
            #endregion
        }

        //A SetUpMenu függvény felállítja a menü oldalt
        private void SetUpMenu(Form myForm, TabPage menu)
        {
            #region Elemek beállítása
            menu.Location = new Point(4, 25);
            menu.Padding = new Padding(3);
            menu.Size = new Size(768, 356);
            menu.Text = "Menü";
            menu.BackgroundImage = new Bitmap("../../../forrasok/menuztetes.jpg");
            menu.BackgroundImageLayout = ImageLayout.Center | ImageLayout.Stretch;


            Menu napimenu1 = mod.GetNapiMenu();
            MyGroup group1 = new MyGroup(
                10,
                "A menü",
                napimenu1.pricetelj.ToString(),
                napimenu1.pricezona.ToString(),
                napimenu1.name1,
                napimenu1.name2);

            group1.SetCountClick(myForm);
            Menu napimenu2 = mod.GetNapiMenu();
            MyGroup group2 = new MyGroup(
                130,
                "B menü",
                napimenu2.pricetelj.ToString(),
                napimenu2.pricezona.ToString(),
                napimenu2.name1,
                napimenu2.name2);

            group2.SetCountClick(myForm);


            elvitel.Location = new Point(
                group2.Location.X + 80,
                group2.Location.Y + group2.Size.Height + 20
                );
            elvitel.BackColor = Color.Transparent;
            elvitel.AutoSize = true;
            elvitel.TabStop = false;
            Label elviteltxt = new Label();
            elviteltxt.Text = "Elvitelre: ";
            elviteltxt.Location = new Point(elvitel.Location.X - 70, elvitel.Location.Y);
            elviteltxt.Font = new Font("Arial", 12);
            elviteltxt.BackColor = Color.Transparent;


            Button rendel = new Button();
            rendel.Text = "Rendel";
            rendel.TabStop = false;
            rendel.Location = new Point(elvitel.Location.X + 50, elvitel.Location.Y);
            rendel.Font = new Font("Arial", 12);
            rendel.AutoSize = true;

            Button cancel = new Button();
            cancel.Text = "Mégsem";
            cancel.Font = new Font("Arial", 12);
            cancel.TabStop = false;
            cancel.Location = new Point(rendel.Location.X + rendel.Width + 20, rendel.Location.Y);
            cancel.AutoSize = true;

            Label pay = new Label();
            pay.Text = "Fizetendő";
            pay.Font = new Font("Arial", 12, FontStyle.Bold);
            pay.ForeColor = Color.White;
            pay.Location = new Point(cancel.Location.X + cancel.Width + 20, cancel.Location.Y);
            pay.AutoSize = true;
            pay.BackColor = Color.Transparent;

            payUpt.Enabled = false;
            payUpt.BorderStyle = BorderStyle.FixedSingle;
            payUpt.Location = new Point(pay.Location.X + pay.Width, pay.Location.Y);

            #endregion

            #region Eventek

            group1.count.ValueChanged += (s, e) =>
            {
                payUpt.Text = mod.DataChange(group1.ToPay(), group2.ToPay(), elvitel.Checked);
            };
            group2.count.ValueChanged += (s, e) =>
            {
                payUpt.Text = mod.DataChange(group1.ToPay(), group2.ToPay(), elvitel.Checked);
            };
            group1.myInner.radio1.CheckedChanged += (s, e) =>
            {
                payUpt.Text = mod.DataChange(group1.ToPay(), group2.ToPay(), elvitel.Checked);
            };
            group1.myInner.radio2.CheckedChanged += (s, e) =>
            {
                payUpt.Text = mod.DataChange(group1.ToPay(), group2.ToPay(), elvitel.Checked);
            };
            group2.myInner.radio1.CheckedChanged += (s, e) =>
            {
                payUpt.Text = mod.DataChange(group1.ToPay(), group2.ToPay(), elvitel.Checked);
            };
            group2.myInner.radio2.CheckedChanged += (s, e) =>
            {
                payUpt.Text = mod.DataChange(group1.ToPay(), group2.ToPay(), elvitel.Checked);
            };
            elvitel.CheckedChanged += (s, e) =>
            {
                payUpt.Text = mod.DataChange(group1.ToPay(), group2.ToPay(), elvitel.Checked);
            };

            rendel.Click += (s, e) =>
            {
                Rendeles();
                ClearPage(group1, group2, elvitel);
            };
            cancel.Click += (s, e) =>
            {
                ClearPage(group1, group2, elvitel);
                MessageBox.Show("Sikeres törlés!");
            };

            #endregion

            #region Elemek hozzáadása

            menu.Controls.Add(elvitel);
            menu.Controls.Add(elviteltxt);
            menu.Controls.Add(group1);
            menu.Controls.Add(group2);
            menu.Controls.Add(rendel);
            menu.Controls.Add(cancel);
            menu.Controls.Add(pay);
            menu.Controls.Add(payUpt);

            #endregion

        }

        //A SetUpRendelesek függvény felállítja a rendelések oldalt
        private void SetUpRendelesek(Form myForm, TabPage rendelesek)
        {
            #region Elemek létrehozása
            rendelesek.Location = new Point(4, 25);
            rendelesek.Padding = new Padding(3);
            rendelesek.Size = new Size(192, 71);
            rendelesek.Text = "Rendelések";
            rendelesek.BackgroundImage = new Bitmap("../../../forrasok/menuztetes.jpg");
            rendelesek.BackgroundImageLayout = ImageLayout.Center | ImageLayout.Stretch;

            //Elemek listája
            elemek.Location = new Point(20, 20);
            elemek.Size = new Size(180, 200);
            elemek.TabStop = false;


            Label bevetel = new Label();
            bevetel.Text = "Bevétel: ";
            bevetel.Location = new Point(
                elemek.Location.X,
                elemek.Location.Y + elemek.Size.Height + 30);
            bevetel.Font = new Font("Arial", 14);
            bevetel.AutoSize = true;
            bevetel.BackColor = Color.Transparent;

            bevetelIpt.Location = new Point(
                    elemek.Location.X + elemek.Size.Width - 100,
                    bevetel.Location.Y
                );
            bevetelIpt.Enabled = false;
            bevetelIpt.Size = new Size(100, bevetel.Size.Height);
            bevetelIpt.TabStop = false;


            //Irányítások
            Panel group = new Panel();
            group.Location = new Point(240, 40);
            group.Size = new Size(300, 180);

            //Azonosító
            Label id = new Label();
            id.Text = "Azonosító";
            id.Location = new Point(20, 20);
            id.Font = new Font("Arial", 14);

            TextBox idIpt = new TextBox();
            idIpt.Size = new Size(120, id.Size.Height);
            idIpt.Location = new Point(id.Size.Width + 40, id.Location.Y);
            idIpt.ReadOnly = true;
            idIpt.TabStop = false;

            //Összeg
            Label price = new Label();
            price.Text = "Összeg";
            price.Location = new Point(20, 60);
            price.Font = new Font("Arial", 14);

            TextBox priceIpt = new TextBox();
            priceIpt.Size = new Size(120, price.Size.Height);
            priceIpt.Location = new Point(price.Size.Width + 40, price.Location.Y);
            priceIpt.ReadOnly = true;
            priceIpt.TabStop = false;

            //Dátum
            Label date = new Label();
            date.Text = "Dátum";
            date.Location = new Point(20, 100);
            date.Font = new Font("Arial", 14);
            date.AutoSize = true;

            TextBox dateIpt = new TextBox();
            dateIpt.Size = new Size(150, date.Size.Height);
            dateIpt.Location = new Point(date.Size.Width + 10, date.Location.Y);
            dateIpt.ReadOnly = true;
            dateIpt.TabStop = false;


            //Elvitel
            Label takeaway = new Label();
            takeaway.Text = "Elvitel";
            takeaway.Location = new Point(20, 140);
            takeaway.Font = new Font("Arial", 14);

            CheckBox takeawayIpt = new CheckBox();
            takeawayIpt.Enabled = false;
            takeawayIpt.Location = new Point(takeaway.Size.Width + 80, takeaway.Location.Y);
            takeawayIpt.TabStop = false;



            //Gombok
            Button delete = new Button();
            delete.Location = new Point(
                group.Location.X,
                group.Location.Y + group.Size.Height + 10
                );
            delete.Font = new Font("Arial", 12, FontStyle.Bold);
            delete.Size = new Size(120, 50);
            delete.Text = "Rendelés törlése";
            delete.TabStop = false;


            Button deleteAll = new Button();
            deleteAll.Font = new Font("Arial", 12, FontStyle.Bold);
            deleteAll.Size = new Size(160, 50);
            deleteAll.Location = new Point(
                group.Location.X + group.Size.Width - deleteAll.Size.Width,
                group.Location.Y + group.Size.Height + 10
                );
            deleteAll.Text = "Minden rendelés törlése";
            deleteAll.TabStop = false;
            #endregion

            #region Event kezelések
            elemek.Click += (s, e) =>
            {
                elemek.Enabled = false;
                myForm.Focus();
                elemek.Enabled = true;
                idIpt.Text = mod.GetLine(elemek.SelectedIndex).id.ToString();
                priceIpt.Text = mod.GetLine(elemek.SelectedIndex).price.ToString() + " Ft";
                dateIpt.Text = mod.GetLine(elemek.SelectedIndex).date.ToString();
                takeawayIpt.Checked = mod.GetLine(elemek.SelectedIndex).elvitel;
            };
            delete.Click += (s, e) =>
            {
                if (elemek.SelectedIndex >= 0)
                {
                    mod.Delete(Convert.ToInt32(idIpt.Text));
                    FillList(elemek, bevetelIpt);
                    MessageBox.Show("Sikeres törlés!");
                }
                else
                {
                    MessageBox.Show("Ehhez a művelethez ki kell választanod egy elemet!");
                }
            };
            deleteAll.Click += (s, e) =>
            {
                ClearAll(elemek);
            };
            #endregion

            #region Elemek hozzáadása

            rendelesek.Controls.Add(elemek);

            group.Controls.Add(id);
            group.Controls.Add(idIpt);

            group.Controls.Add(price);
            group.Controls.Add(priceIpt);

            group.Controls.Add(date);
            group.Controls.Add(dateIpt);

            group.Controls.Add(takeaway);
            group.Controls.Add(takeawayIpt);

            rendelesek.Controls.Add(group);

            rendelesek.Controls.Add(bevetel);
            rendelesek.Controls.Add(bevetelIpt);
            rendelesek.Controls.Add(delete);
            rendelesek.Controls.Add(deleteAll);
            #endregion

        }

        //A Rendelés függvény meghívja a Model azonos nevü metódusát és frissíti az eddig leadott rendelések listáját
        private void Rendeles()
        {
            mod.Rendeles(payUpt.Text, elvitel.Checked);
            FillList(elemek, bevetelIpt);
        }

        //A myData lista tartalmazza az eddig leaadott rendeléseket
        List<Rendelesek> myData = mod.GiveData();

        //A FillList függvény felelős a rendelések oldalon található, eddig leadott rendeléseket tartalmazó, lista doboz frissítéséért
        public void FillList(ListBox lb, TextBox bevetel)
        {
            lb.Items.Clear();
            mod.Frissites();
            myData = mod.GiveData();
            foreach (Rendelesek item in myData)
            {
                string hol = item.elvitel ? "Elvitelre" : "Helyben";
                lb.Items.Add($"{item.price} Ft:{item.date}:{hol}");
            }
            if (myData.Count > 0)
            {
                bevetel.Text = myData.Select(x => x.price).Sum().ToString();
            }
        }

        //A ClearAll meghívja a Model osztály azonos nevű metódusát
        public void ClearAll(ListBox elemek)
        {
            mod.ClearAll(elemek);
        }

        /*
         * A ClearPage függvény kijelöletlenné teszi az összes rádiógombot és kijelölőnégyzetet a menü oldalon,
         * illetve nullázza a NumericUpDown beviteli mezőket
         */
        private void ClearPage(MyGroup group1, MyGroup group2, CheckBox elvitel)
        {
            group1.count.Value = 0;
            group1.myInner.radio1.Checked = false;
            group1.myInner.radio2.Checked = false;
            group2.count.Value = 0;
            group2.myInner.radio1.Checked = false;
            group2.myInner.radio2.Checked = false;
            elvitel.Checked = false;
        }
    }
}
