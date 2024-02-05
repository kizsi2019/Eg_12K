using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IskolaGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            StreamReader sr = new StreamReader("nevekGui.txt");
            while (!sr.EndOfStream)
            {
                tanulokLista.Items.Add(sr.ReadLine());
            }
            sr.Close();

        }

        private void btnTöröl_Click(object sender, RoutedEventArgs e)
        {
            if (tanulokLista.SelectedItem != null)
            {
                tanulokLista.Items.Remove(tanulokLista.SelectedItem);
            }
            else
            {
                MessageBox.Show("Nem jelölt ki rekordot");
            }
        }

        private void btnMentés_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("nevekNew.txt");
                foreach (var item in tanulokLista.Items)
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