using Bolnica.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Migrations;
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
        private string details;
        private List<Zapi> zapis;
        public string Detailss { get => details; set => details = value; }
        public List<Zapi> Zapis { get => zapis; set => zapis = value; }


        User User;
        public SpisZapkVrachh(User user)
        {
            InitializeComponent();
            DataContext = this;
            User = user;
            if (User.Rol_ID == 1)
            {
              var UserKlient = User.Klients.FirstOrDefault(p=> p.User.Equals(User)); 
              Zapis = App.Context.Zapis.Where(p=> p.ID_Klient == UserKlient.ID).ToList();  
            }
              else
                if (User.Rol_ID == 2)
            {
               
                var UserVrachi = User.Vrachis.FirstOrDefault(p => p.User.Equals(User));
                Zapis = App.Context.Zapis.Where(p => p.Vrach == UserVrachi.ID).ToList();
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var currentZapi = (sender as Button).DataContext as Zapi;
            currentZapi.Details = Detailss;

                App.Context.Zapis.Attach(currentZapi);
                App.Context.Entry(currentZapi).Property(x => x.Details).IsModified = true;
                App.Context.SaveChanges();

        }

        private void BtnEnd_Click(object sender, RoutedEventArgs e)
        {
            var currentZapi = (sender as Button).DataContext as Zapi;
            currentZapi.EndHealing = "Окончено";

            App.Context.Zapis.Attach(currentZapi);
            App.Context.Entry(currentZapi).Property(x => x.EndHealing).IsModified = true;
            App.Context.SaveChanges();
        }
    }
}
