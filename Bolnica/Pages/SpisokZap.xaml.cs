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

namespace Bolnica.Pages
{
    /// <summary>
    /// Логика взаимодействия для SpisokZap.xaml
    /// </summary>
    public partial class SpisokZap : Page
    {
        public SpisokZap()
        {
            InitializeComponent();
            ComboSortBy.SelectedIndex = 0;
            UpdateBol();
        }
        public void UpdateBol()
        {
            var bol = App.Context.Vrachis.ToList();
            // Сортировка по должности
            if (ComboSortBy.SelectedIndex == 1)
                bol = bol.Where(p => p.Doljnost == "психиатр").ToList();
            if (ComboSortBy.SelectedIndex == 2)
                bol = bol.Where(p => p.Doljnost == "нарколог").ToList();
            if (ComboSortBy.SelectedIndex == 3)
                bol = bol.Where(p => p.Doljnost == "офтальмолог").ToList();
            if (ComboSortBy.SelectedIndex == 4)
                bol = bol.Where(p => p.Doljnost == "терапевт").ToList();
            if (ComboSortBy.SelectedIndex == 5)
                bol = bol.Where(p => p.Doljnost == "аллерголог").ToList();
            if (ComboSortBy.SelectedIndex == 6)
                bol = bol.Where(p => p.Doljnost == "невропатолог").ToList();
            if (ComboSortBy.SelectedIndex == 7)
                bol = bol.Where(p => p.Doljnost == "хирург").ToList();
            if (ComboSortBy.SelectedIndex == 8)
                bol = bol.Where(p => p.Doljnost == "пульмонолог").ToList();
            if (ComboSortBy.SelectedIndex == 9)
                bol = bol.Where(p => p.Doljnost == "санитарный врач").ToList();
            if (ComboSortBy.SelectedIndex == 10)
                bol = bol.Where(p => p.Doljnost == "физиотерапевт").ToList();
            if (ComboSortBy.SelectedIndex == 11)
                bol = bol.Where(p => p.Doljnost == "ортопед").ToList();
            if (ComboSortBy.SelectedIndex == 12)
                bol = bol.Where(p => p.Doljnost == "реаниматолог").ToList();
            if (ComboSortBy.SelectedIndex == 13)
                bol = bol.Where(p => p.Doljnost == "кардиолог").ToList();
            if (ComboSortBy.SelectedIndex == 14)
                bol = bol.Where(p => p.Doljnost == "эпидемиолог").ToList();
            // Поиск
            bol = bol.Where(p => p.Familia.ToLower().Contains(TboxSerch.Text.ToLower())).ToList();
            LviewService.ItemsSource = bol;
        }
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
        }
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
        }
        private void TboxSerch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateBol();
        }
        private void ComboSortBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateBol();
        }
        private void BtnZapis_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ZapkVrach());
        }
        private void BtnSpiszap_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SpisZapkVrachh(App.CurrentKlient));
        }
    }
}
