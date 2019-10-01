using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class IstTax
    {
        public string LocationCode { get; set; }
        public int? TaxId { get; set; }
        public string TaxName { get; set; }
        public bool? IsApply { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Added { get; set; }
    }
}
