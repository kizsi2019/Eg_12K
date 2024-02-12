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

namespace OrvosiNobeldijasokGUI
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

        private void btnMentes_Click(object sender, RoutedEventArgs e)
        {
            if (tbEv.Text != "" && tbNev.Text != "" && tbSzH.Text != "" && tbOrszag.Text != "")
            {
                if (int.Parse(tbEv.Text) <= 1989)
                {
                    MessageBox.Show("Hiba! Az évszám nem megfelelő", "Mentés");
                    return;
                }
                try
                {
                    List<string> ki = new List<string>();
                    ki.Add("Év;Név;SzületésHalálozás;Országkód");
                    ki.Add($"{tbEv.Text};{tbNev.Text};{tbSzH.Text};{tbOrszag.Text}");
                    File.WriteAllLines("uj_dijazott.txt", ki);
                    tbEv.Text = "";
                    tbNev.Text = "";
                    tbSzH.Text = "";
                    tbOrszag.Text = "";
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Hiba az állomány irásánál");
                }
            }
            else MessageBox.Show("Töltsön ki minden mezőt", "Mentés");
        }
    }
}
