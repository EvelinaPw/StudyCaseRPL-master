//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudyCaseRPL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShoppingCart
    {
        public int RecordID { get; set; }
        public string CartID { get; set; }
        public int Quantity { get; set; }
        public int BookID { get; set; }
        public System.DateTime DateCreated { get; set; }
    
        public virtual Book Book { get; set; }
    }
}