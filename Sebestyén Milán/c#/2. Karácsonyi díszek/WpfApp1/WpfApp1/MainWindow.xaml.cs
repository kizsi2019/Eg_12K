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

        public static int nap = 0, jo = 0, eladott = 0, ossz = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            jo = Convert.ToInt32(kesz.Text);
            eladott = Convert.ToInt32(arul.Text);
            if (jo < 0 || eladott < 0)
            {
                hiba.Content = "Negatív számot nem adhat meg!";
            }
            else if (eladott > jo + ossz)
            {
                hiba.Content = "Túl sok az eladott angyalka!";
            }
            else
            {
                nap = Convert.ToInt32(naps.SelectedItem.ToString());
                ossz += jo - eladott;
                megjelen.Text += nap + ".nap: \t+" + jo + " \t-" + eladott + " \t= \t" + ossz + "\n";
                for (int i = 1; i <= nap; i++)
                {
                    naps.Items.Remove(i);
                }
                kesz.Text = "0";
                arul.Text = "0";
                hiba.Content = "";
            }
        
    }

        public MainWindow()
        {
            InitializeComponent();
            if (naps.Items.Count < 40)
            {
                naps.Items.Clear();
                for (int i = 1; i <= 40; i++)
                {
                    naps.Items.Add(i);
                }
            }

        }
    }
}
