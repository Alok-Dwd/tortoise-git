using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class TaxName
    {
        public string TaxId { get; set; }
        public string TaxName1 { get; set; }
        public bool? IsApplicable { get; set; }
        public string LocationCode { get; set; }
    }
}
