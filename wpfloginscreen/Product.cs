//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wpfloginscreen
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int Product_ID { get; set; }
        public Nullable<int> UserUser_ID { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public int InventoryId { get; set; }
    
        public virtual Inventory Inventory { get; set; }
    }
}
