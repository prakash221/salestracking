//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TransactionDetail
    {
        public int TransactionDetailID { get; set; }
        public int TransactionId { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public string Units { get; set; }
    }
}