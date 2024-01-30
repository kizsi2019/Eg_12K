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

namespace Toto2GUI
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

        

        private void eredmenyTB_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            kevesCB.IsChecked = eredmenyTB.Text.Length != 14;
            kevesCB.Content = $"Nem megfelelő a karakterek száma ({eredmenyTB.Text.Length})";
            List<Char> lista = new List<Char>();
            foreach (var i in eredmenyTB.Text)
            {
                if ("12X".IndexOf(i) == -1)
                {
                    lista.Add(i);
                }
            }
            helytelenCB.Content = $"Helytelen karakter az eredményekben ({string.Join(";", lista)})";
            helytelenCB.IsChecked = lista.Count != 0;
            mentes.IsEnabled = kevesCB.IsChecked == false && helytelenCB.IsChecked == false;
        }
    }
}
