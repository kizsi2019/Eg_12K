
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

namespace iskolaGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void AdatokBetöltése()
        {
            foreach(var i in File.ReadAllLines("nevekGUI.txt"))
            {
                EzEgyListBox.Items.Add(i);
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            AdatokBetöltése();
        }
        

        

        private void btnTorles_Click(object sender, RoutedEventArgs e)
        {
            if (EzEgyListBox.SelectedItem != null)
            {
                EzEgyListBox.Items.Remove(EzEgyListBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Nem jelölt ki rekordot");
            }
        }

        private void btnMentes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("nevekNew.txt");
                foreach (var item in EzEgyListBox.Items)
                {
                    sw.WriteLine(item);
                }
                sw.Close();
                MessageBox.Show("Sikeres mentés!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
