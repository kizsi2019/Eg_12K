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
        }

        private void BtnMentés_Click(object sender, RoutedEventArgs e)
        {
            if(TbÉv.Text != "" && TbNév.Text != "" && TBSzH.Text != "" && TbOrszág.Text != "")
            {
                if(int.Parse(TbÉv.Text) <= 1989)
                {
                    MessageBox.Show("Hiba! Az évszám nem megfelelő!", "Mentés");
                    return;
                }
                try
                {
                    List<string> ki = new List<string>();
                    ki.Add("Év;Név;SzületésHalálozás;Országkód");
                    ki.Add($"{TbÉv.Text};{TbNév.Text};{TBSzH.Text};{TbOrszág.Text}");
                    File.WriteAllLines("uj_dijazott.txt", ki);
                    TbÉv.Text = "";
                    TbNév.Text = "";
                    TBSzH.Text = "";
                    TbOrszág.Text = "";
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Hiba az állomány írásánál!");
                }
            }
            else
            {
                MessageBox.Show("Töltsön ki minden mezőt!", "Mentés");
            }
        }
    }
}
