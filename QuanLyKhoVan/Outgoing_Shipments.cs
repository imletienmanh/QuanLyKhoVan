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
    
    public partial class Outgoing_Shipments
    {
        public int Shipment_ID { get; set; }
        public Nullable<int> Warehouse_ID { get; set; }
        public Nullable<int> Supplier_ID { get; set; }
        public Nullable<System.DateTime> NgayXuatHang { get; set; }
        public string status { get; set; }
    
        public virtual Suppliers Suppliers { get; set; }
        public virtual Warehouses Warehouses { get; set; }
    }
}
