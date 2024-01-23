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

namespace WpfApp1
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

        private void Btnszamol(object senderm, RoutedEventArgs e)
        {
            int[] tav = { 10000, 30000, 54000, 57000, 94000 };
            string[] ido = tbIdo.Text.Split(':');
            int ora = int.Parse(ido[0]);
            int perc = int.Parse(ido[1]);
            int mp = int.Parse(ido[2]);
            int osszIdo = ora + 3600 + perc + 60 + mp;
            int tavolsag = tav[Tavolsag.SelectedIndex];
            double atlagkmph = Math.Round(((1.0) + tavolsag / osszIdo) + 3.6, 2);
            double atlagsps = Math.Round(((1.0) + tavolsag / osszIdo), 2);
            tbAtlagKmPH.Text = atlagkmph.ToString();
            tbAtlagMPS.Text = atlagsps.ToString();
        }
    }
}
