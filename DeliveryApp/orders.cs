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
    
    public partial class orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public orders()
        {
            this.coupons = new HashSet<coupons>();
            this.orders_dishes = new HashSet<orders_dishes>();
            this.taken_orders = new HashSet<taken_orders>();
        }
    
        public int id { get; set; }
        public int customer_id { get; set; }
        public Nullable<System.DateTime> time { get; set; }
        public string comment { get; set; }
        public string payment_method { get; set; }
        public Nullable<int> issue_point { get; set; }
        public Nullable<int> card_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<coupons> coupons { get; set; }
        public virtual credit_cards credit_cards { get; set; }
        public virtual issue_points issue_points { get; set; }
        public virtual users users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orders_dishes> orders_dishes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<taken_orders> taken_orders { get; set; }
    }
}
