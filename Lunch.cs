//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFEatTracker
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lunch
    {
        public int id_lunch { get; set; }
        public string eat_lunch { get; set; }
        public string kalory_lunch { get; set; }
        public Nullable<int> id_person { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
