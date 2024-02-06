using System;
using System.Collections.Generic;
using System.IO;
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

            static void btnMentes_click(object sender, RoutedEventArgs e)
            {
                List<string> list = new List<string>();
                foreach (string s in lstTanulok.Items)
                {
                    list.Add((string)s);
                }
                try
                {
                    File.WriteAllLines("nevekNew.txt", list);
                    MessageBox.Show("Sikeres mentés!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }       

        private void btnTorles_Click(object sender, RoutedEventArgs e)
        {
            if (lstTanulok.SelectedItem != null)
            {
                lstTanulok.Items.Remove(lstTanulok.SelectedItem);
            }
            else
            {
                MessageBox.Show("Nem jelölt ki rekordot");
            }
        }

    }
}
