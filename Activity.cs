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
    
    public partial class Activity
    {
        public int id_activity { get; set; }
        public string Vid_active { get; set; }
        public Nullable<int> id_person { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
