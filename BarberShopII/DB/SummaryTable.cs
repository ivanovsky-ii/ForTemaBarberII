//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BarberShopII.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class SummaryTable
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> DateUse { get; set; }
        public Nullable<int> IdEmployee { get; set; }
        public Nullable<int> IdMaterial { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<decimal> Sum { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Material Material { get; set; }
    }
}
