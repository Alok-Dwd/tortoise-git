using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MarketingVtOc
    {
        public string LocationCode { get; set; }
        public int VariableType { get; set; }
        public int OperatorCode { get; set; }
        public int? DisplayOrder { get; set; }
    }
}
