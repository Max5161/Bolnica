using Bolnica.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;

namespace Bolnica
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Entities.BOOLEntities3 Context
        { get; } = new Entities.BOOLEntities3();


        public static Klient CurrentKlient { get; set; } = null;

    }
}
