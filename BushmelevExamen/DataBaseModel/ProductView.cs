//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BushmelevExamen.DataBaseModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductView
    {
        public string ArticleNumber { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Category { get; set; }
        public string Supplier { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public Nullable<byte> MaxDiscount { get; set; }
        public Nullable<byte> Discount { get; set; }
        public int Quantity { get; set; }
        public string Photo { get; set; }
    }
}
