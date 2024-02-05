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

namespace nobelgrapic
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(ev.Text!="" && nev.Text != "" && szulhal.Text != "" && orsz.Text != ""){
                MessageBox.Show("hiba");
            }
            try
            {
                List<string> ki = new List<string>();
                ki.Add("Év,Név,Születes/halál,Ország");
                ki.Add($"{ev.Text},{nev.Text},{szulhal.Text}.{orsz.Text}");
                File.WriteAllLines("ujdijjazott.txt",ki);
                ev.Text = "";
                nev.Text = "";
                szulhal.Text = "";
                orsz.Text = "";
            }
            catch(Exception) {
                MessageBox.Show("hibas");
            }

        }
    }
}
