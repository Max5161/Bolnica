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
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            var Klient = App.Context.Klients
                .FirstOrDefault(p => p.Login == TBoxLogin.Text && p.Password == PBoxPassword.Password);

            if (Klient != null)
            {
                App.klient = Klient;
                NavigationService.Navigate(new SpisokZap());
            }
                else
            {
                MessageBox.Show("Пользователь с такими данными не найден.", "Ошибки",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void TBoxLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.Registration());
        }
    }
}
