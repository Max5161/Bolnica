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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        private Entities.Klient _currentService = null;
        public Registration()
        {
            InitializeComponent();
        }
        private void ButttonADDKlient_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TboxFamilia.Text) || string.IsNullOrWhiteSpace(TboxName.Text) || string.IsNullOrWhiteSpace(TboxOtchestvo.Text)
                || string.IsNullOrWhiteSpace(TboxVozast.Text) || string.IsNullOrWhiteSpace(TboxRabota.Text) || (string.IsNullOrWhiteSpace(TboxLogin.Text)
                || string.IsNullOrWhiteSpace(Tboxpassword.Text) == true))
            {
                MessageBox.Show("Не заполнены данные", "Ошибка");
            } else
            {
                var Zapic = new Entities.Klient
                {
                    Familia = TboxFamilia.Text,
                    Name = TboxName.Text,
                    Otchestvo = TboxOtchestvo.Text,
                    Vozrast = int.Parse(TboxVozast.Text),
                    Mesto_raboti = TboxRabota.Text,
                };
                App.Context.Klients.Add(Zapic);
                App.Context.SaveChanges();
                NavigationService.GoBack();
            }
           
        }

        private void TboxRabota_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TboxLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tboxpassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TboxOtchestvo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
