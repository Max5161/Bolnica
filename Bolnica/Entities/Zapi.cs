//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bolnica.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zapi
    {
        public int ID { get; set; }
        public int ID_Med_kard { get; set; }
        public int ID_Klient { get; set; }
        public int Vrach { get; set; }
        public string Details { get; set; }
    
        public virtual Klient Klient { get; set; }
        public virtual Med_karta Med_karta { get; set; }
    }
}
