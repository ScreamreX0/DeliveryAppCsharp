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
    
    public partial class couriers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public couriers()
        {
            this.couriers_transport = new HashSet<couriers_transport>();
            this.taken_orders = new HashSet<taken_orders>();
        }
    
        public int id { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<int> issue_point { get; set; }
        public Nullable<int> current_transport { get; set; }
        public Nullable<int> status { get; set; }
    
        public virtual courier_statuses courier_statuses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<couriers_transport> couriers_transport { get; set; }
        public virtual issue_points issue_points { get; set; }
        public virtual couriers_transport couriers_transport1 { get; set; }
        public virtual users users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<taken_orders> taken_orders { get; set; }
    }
}