using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;

namespace IskolaGUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // 10. Feladat: Lista feltöltése a nevekGUI.txt tartalmával
            FajlbolBetolt("nevekGUI.txt");
        }

        private void FajlbolBetolt(string fajlnev)
        {
            try
            {
                // Fájl beolvasása
                List<string> sorok = new List<string>(File.ReadAllLines(fajlnev));

                // Lista feltöltése
                tanulokListBox.ItemsSource = sorok;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba a fájl beolvasása során: {ex.Message}", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TorlesButton_Click(object sender, RoutedEventArgs e)
        {
            // 11. Feladat: Kijelölt tanuló törlése
            if (tanulokListBox.SelectedIndex != -1)
            {
                // Közbenső lista létrehozása
                List<string> tanulokLista = new List<string>(tanulokListBox.Items.Cast<string>());

                // Kijelölt elem törlése a közbenső listából
                tanulokLista.RemoveAt(tanulokListBox.SelectedIndex);

                // Frissítés az ItemsSource használatával
                tanulokListBox.ItemsSource = tanulokLista;
            }
            else
            {
                MessageBox.Show("Nem jelölt ki tanulót!", "Figyelmeztetés", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


        private void MentesButton_Click(object sender, RoutedEventArgs e)
        {
            // 12. Feladat: Lista mentése nevekNEW.txt állományba
            try
            {
                File.WriteAllLines("nevekNEW.txt", (IEnumerable<string>)tanulokListBox.ItemsSource);
                MessageBox.Show("Sikeres mentés!", "Mentés", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba a mentés során: {ex.Message}", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
