using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AI_Projekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            inputBox.PreviewMouseDown += (s, e) =>
            {
                var dialog = new FolderBrowserDialog();
                dialog.Description = "Choose a folder";
                var result = dialog.ShowDialog();
                if (result.ToString() != "Cancel")
                {
                    inputBox.Text = dialog.SelectedPath;
                }
            };    
        }
    }
}
