using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class IstTaxDetails
    {
        public int? IstId { get; set; }
        public int? SrNo { get; set; }
        public string ItemCode { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Price { get; set; }
        public decimal? Tax1Rate { get; set; }
        public decimal? Tax1Amount { get; set; }
        public decimal? Tax2Rate { get; set; }
        public decimal? Tax2Amount { get; set; }
        public decimal? Tax3Rate { get; set; }
        public decimal? Tax3Amount { get; set; }
        public decimal? Tax4Rate { get; set; }
        public decimal? Tax4Amount { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }
    }
}
