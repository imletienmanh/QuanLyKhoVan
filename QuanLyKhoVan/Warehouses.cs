//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKhoVan
{
    using System;
    using System.Collections.Generic;
    
    public partial class Warehouses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Warehouses()
        {
            this.Incoming_Shipments = new HashSet<Incoming_Shipments>();
            this.Inventory_Checks = new HashSet<Inventory_Checks>();
            this.Outgoing_Shipments = new HashSet<Outgoing_Shipments>();
        }
    
        public int Warehouse_ID { get; set; }
        public string DiaDiem { get; set; }
        public string TenKho { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Incoming_Shipments> Incoming_Shipments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventory_Checks> Inventory_Checks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Outgoing_Shipments> Outgoing_Shipments { get; set; }
    }
}