using System;
using System.Collections.Generic;

namespace IndiaHomesDAL.Models
{
    public partial class PromoCode
    {
        public string PromoId { get; set; }
        public Nullable<decimal> MaxDisc { get; set; }
        public Nullable<decimal> MinAmount { get; set; }
        public Nullable<System.DateTime> ValidToDate { get; set; }
        public Nullable<System.DateTime> ValidFromDate { get; set; }
        public string Name { get; set; }
        public Nullable<bool> TypeOfCode { get; set; }
    }
}
