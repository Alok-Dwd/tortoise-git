using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class UserDefinedTaxRatesDetails
    {
        public string LocationCode { get; set; }
        public int UserDefinedTaxRateId { get; set; }
        public int TaxId { get; set; }
        public int CategoryId { get; set; }
        public bool Discounted { get; set; }
        public float Rate { get; set; }
        public decimal MinimumAmount { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
