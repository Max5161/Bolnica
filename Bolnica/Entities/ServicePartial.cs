using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Entities
{
    public partial class Vrachi
    {
        public string stajs
        {
            get
            {
                if (Stag == Stag)
                    return $"Стаж: {Stag} лет";
                else
                    return "";
  
            }
        }
        public string Familias
        {
            get
            {
                if (Familia == Familia)
                    return $"ФИО: {Familia}";
                else
                    return "";
            }
        }
        public string Doljnosts
        {
            get
            {
                if (Doljnost == Doljnost)
                    return $"Должность: {Doljnost}";
                else
                    return "";
            }
        }

        public string Otdelenies
        {
            get
            {
                if (Otdelenie == Otdelenie)
                    return $"Отделение: {Otdelenie}";
                else
                    return "";
            }
        }

    }

    partial class User
    {
        public string IsReadOnly
        {
            get
            {
                if (App.CurrentKlient.Rol_ID == 2)
                    return "False";
                else return "True";
            }
        }

        public string AdminVisibility
        {
            get
            {
                if ( App.CurrentKlient.Rol_ID == 1)
                    return "Collapsed"; else return "Visible";
            }
        }
    }
    partial class Zapi
    {
        public string IsReadOnly
        {
            get
            {
                if (App.CurrentKlient.Rol_ID == 2)
                    return "False";
                else return "True";
            }
        }
        public string AdminVisibility
        {
            get
            {
                if (App.CurrentKlient.Rol_ID == 1)
                    return "Collapsed";
                else return "Visible";
            }
        }
    }
}
