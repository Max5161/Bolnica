﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
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

        public static Entities.Klient klient = null;
    }
}
