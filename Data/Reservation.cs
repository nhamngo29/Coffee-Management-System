//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public string Status { get; set; }
        public Nullable<int> IdTable { get; set; }
        public Nullable<int> IdSataff { get; set; }
    
        public virtual staff staff { get; set; }
        public virtual TableCoffee TableCoffee { get; set; }
    }
}
