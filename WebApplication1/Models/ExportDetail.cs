//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExportDetail
    {
        public string exportID { get; set; }
        public string productID { get; set; }
        public string productName { get; set; }
        public int productPrice { get; set; }
        public int productQuantity { get; set; }
        public string productOrigin { get; set; }
    
        public virtual Export Export { get; set; }
        public virtual Product Product { get; set; }
    }
}
