//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeliveryApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class partners
    {
        public int id { get; set; }
        public Nullable<int> menu_id { get; set; }
        public string name { get; set; }
        public string support_number { get; set; }
        public string support_email { get; set; }
    
        public virtual menu menu { get; set; }
    }
}
