using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class SalesPeriods
    {
        public string LocationCode { get; set; }
        public string SalesPeriodCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public int Color { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
