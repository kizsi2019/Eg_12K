using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TotoGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Eredények_TextChanged(object sender, TextChangedEventArgs e)
        {
            Hossz.IsChecked = Eredények.Text.Length != 14;
            Hossz.Content = $"Nem megfelelő a karakterek száma ({Eredények.Text.Length})";
            List<Char> hibásKarakterek = new List<char>();
            foreach (var i in Eredények.Text)
            {
                if ("12X".IndexOf(i) == -1)
                {
                    hibásKarakterek.Add(i);
                }
            }
            HibásKarakter.Content = $"Helytelen karakter az eredményekben ({string.Join(";", hibásKarakterek)})";
            HibásKarakter.IsChecked = hibásKarakterek.Count != 0;
            Mentés.IsEnabled = Hossz.IsChecked == false && HibásKarakter.IsChecked == false;
        }
    }
}
