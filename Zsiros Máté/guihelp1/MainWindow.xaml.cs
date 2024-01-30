using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace TotoGUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Eredények_TextChanged(object sender, TextChangedEventArgs e)
        {
            cbHossz.IsChecked = Eredények.Text.Length != 14;
            cbHossz.Content = $"Nem megfelelő a karakterek száma ({Eredények.Text.Length})";
            List<Char> hibásKarakterek = new List<char>();
            foreach (var i in Eredények.Text)
            {
                if ("12X".IndexOf(i) == -1)
                {
                    hibásKarakterek.Add(i);
                }
            }
            cbHibásKarakter.Content = $"Helytelen karakter az eredményekben ({string.Join(";", hibásKarakterek)})";
            cbHibásKarakter.IsChecked = hibásKarakterek.Count != 0;
            Mentés.IsEnabled = cbHossz.IsChecked == false && cbHibásKarakter.IsChecked == false;
        }
    }
}
