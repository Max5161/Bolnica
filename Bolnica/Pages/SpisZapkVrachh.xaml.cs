using Bolnica.Entities;
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
    /// Логика взаимодействия для SpisZapkVrachh.xaml
    /// </summary>
    public partial class SpisZapkVrachh : Page
    {
        User User;
        public SpisZapkVrachh(User user)
        {
            InitializeComponent();
            User = user;
            if (User.Rol_ID == 1)
            {
              var UserKlient = User.Klients.FirstOrDefault(p=> p.User.Equals(User)); 
              LviewService1.ItemsSource = App.Context.Zapis.Where(p=> p.ID_Klient == UserKlient.ID).ToList();  
            }
              else
                if (User.Rol_ID == 2)
            {
               
                var UserVrachi = User.Vrachis.FirstOrDefault(p => p.User.Equals(User));
                LviewService1.ItemsSource = App.Context.Zapis.Where(p => p.Vrach == UserVrachi.ID).ToList();
            }
        }
    }
}
