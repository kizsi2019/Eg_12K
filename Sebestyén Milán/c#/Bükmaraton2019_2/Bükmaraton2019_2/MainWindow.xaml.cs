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

namespace Bükmaraton2019_2
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
        private void btnSzamol_click(object sender, RoutedEventArgs e)
        {
            int[] tav = { 16000, 38000, 54000, 57000, 94000 };
            string[] ido = cdido.Text.Split(':');
            int ora = int.Parse(ido[0]);
            int perc = int.Parse(ido[1]);
            int mp = int.Parse(ido[2]);
            int oszido=ora*3600+perc*60+mp;
            int tavolsag = tav[cdtav.SelectedIndex];
            double kilometerperour = Math.Round(((1.0 * tavolsag) / oszido) * 3.6, 2);
            double meterpersec = Math.Round((1.0) * (tavolsag / oszido), 2);
            atlagkilometerperora.Text= kilometerperour.ToString();
            atlagmeterpermasodperc.Text=meterpersec.ToString();
        }
    }
}
