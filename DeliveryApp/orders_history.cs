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
    
    public partial class orders_history
    {
        public int id { get; set; }
        public Nullable<int> taken_order_id { get; set; }
        public Nullable<int> transport_id { get; set; }
        public Nullable<double> total_sum { get; set; }
        public Nullable<double> rating { get; set; }
    
        public virtual couriers_transport couriers_transport { get; set; }
        public virtual taken_orders taken_orders { get; set; }
    }
}