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
using System.IO;

namespace IskolaGUI
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
                myListBox.Items.Add(i);
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            AdatokBetöltése();
        }

        private void torlesBtn_Click(object sender, RoutedEventArgs e)
        {
            if(myListBox.SelectedItem != null)
            {
                myListBox.Items.Remove(myListBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Nem jelölt ki rekordot");
            }
        }

        private void mentesBtn_Click(object sender, RoutedEventArgs e)
        {
            List<string> lista = new List<string>();
            foreach(var item in myListBox.Items)
            {
                lista.Add((string)item);
            }
            try
            {
                File.WriteAllLines("nevekNEW.txt", lista);
                MessageBox.Show("Sikeres mentés!");
                
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
