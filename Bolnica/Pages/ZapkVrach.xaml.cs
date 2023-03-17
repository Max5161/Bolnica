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
    /// Логика взаимодействия для ZapkVrach.xaml
    /// </summary>
    public partial class ZapkVrach : Page
    {
        private Entities.Zapi _currentService = null;
        public ZapkVrach()
        {
            InitializeComponent();
            Upduk();
            ComboVrachi.ItemsSource = App.Context.Vrachis.ToList();
        }
        public void Upduk()
        {
            var med = App.Context.Med_karta.ToList();



            LviewService.ItemsSource = med;
        }
        private void ComboSortBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
        private void ButttonZapisatsa_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ComboVrachi.Text)
               || string.IsNullOrWhiteSpace(TboxIdClientss.Text) || string.IsNullOrWhiteSpace(TboxIDmedKard.Text) == true)
            {
                MessageBox.Show("Не заполнены данные", "Ошибка");
            }
            else
            {
                if (_currentService == null)
                {
                    var zap = new Entities.Zapi
                    {
                        ID_Med_kard = int.Parse(TboxIDmedKard.Text),
                        ID_Klient = int.Parse(TboxIdClientss.Text),
                        Vrach = (int)ComboVrachi.SelectedValue,

                    };
                    App.Context.Zapis.Add(zap);
                    App.Context.SaveChanges();
                }
                NavigationService.GoBack();
            }
        }
        private void BtnVihod_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.LoginPage());
        }
    }
}
