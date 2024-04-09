using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Solo_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> todos;
        public MainWindow()
        {
            InitializeComponent();
            todos = new ObservableCollection<string>();
            lstTodos.ItemsSource = todos;
        }

        private void AddTodo_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTodo.Text))
            {
                todos.Add(txtTodo.Text);
                txtTodo.Text = "";
            }
            else
            {
                MessageBox.Show("Kérek egy megcsinálandó feladatot :)");
            }
        }

        private void DeleteTodo_Click(Object sender, RoutedEventArgs e)
        {
            if(lstTodos.SelectedItem != null)
            {
                todos.Remove(lstTodos.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Válasz egy elemet!");
            }
        }
    }
}
