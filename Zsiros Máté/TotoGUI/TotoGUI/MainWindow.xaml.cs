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
            cbHossz.IsChecked = Eredmények.Text.Length != 14;
            cbHossz.Content = $"Nem megfelelő a karakterek száma ({Eredmények.Text.Length})";
            List<char> listaKar = new List<char>();
            foreach(var i in Eredmények.Text)
            {
                if("12X".IndexOf(i) == -1)
                {
                    listaKar.Add(i);
                }
            }
            cbHibásKarakter.Content = $"Helytelen karakter az eredményekben({string.Join(";", listaKar)})";
            cbHibásKarakter.IsChecked = listaKar.Count != 0;
            Mentés.IsEnabled = cbHossz.IsChecked == false && cbHibásKarakter.IsChecked == false;
        }
    }
}
