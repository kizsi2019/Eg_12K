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

namespace BukkMaraton2019GUI2
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

        private void btnSzamol_Click(object sender, RoutedEventArgs e)
        {
            int[] tav = { 16000, 38000, 54000, 57000, 94000 };
            string[] Ido = tbIdo.Text.Split(':');
            int ora = int.Parse(Ido[0]);
            int perc = int.Parse(Ido[1]);
            int mp = int.Parse(Ido[2]);
            int osszIdo = ora * 3600 + perc * 60 + mp;
            int tavolsag = tav[cbTav.SelectedIndex];
            double atlagkmph = Math.Round(((1.0) * tavolsag / osszIdo) * 3.6, 2);
            double atlagmps = Math.Round(((1.0) * tavolsag / osszIdo), 2);
            tbAtlagKmPH.Text = atlagkmph.ToString();
            tbAtlagMPS.Text = atlagmps.ToString();


        }
    }
}
