using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class PostalCodes
    {
        public string LocationCode { get; set; }
        public string PostalCode { get; set; }
        public float TaxRate1 { get; set; }
        public float TaxRate2 { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
