using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class BeatsOrderLine
    {
        public string LocationCode { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? OvenTime { get; set; }
        public string MenuCategoryCode { get; set; }
        public string MenuCode { get; set; }
        public string SizeCode { get; set; }
        public short LineNumber { get; set; }
        public short Sequence { get; set; }
        public float Quantity { get; set; }
        public decimal OrderLineTaxableSale1 { get; set; }
        public decimal OrderLineTax1 { get; set; }
        public decimal OrderLineNoTaxDiscount { get; set; }
        public decimal OrderLineTaxDiscount { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
