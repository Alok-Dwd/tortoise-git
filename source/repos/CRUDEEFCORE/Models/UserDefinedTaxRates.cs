using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class UserDefinedTaxRates
    {
        public string LocationCode { get; set; }
        public int UserDefinedTaxRateId { get; set; }
        public int CityCode { get; set; }
        public string PostalCode { get; set; }
        public bool Tax1MinOrderTax { get; set; }
        public decimal Tax1MinOrderAmount { get; set; }
        public bool Tax1CompoundTax2 { get; set; }
        public bool Tax1CompoundTax3 { get; set; }
        public bool Tax1CompoundTax4 { get; set; }
        public bool Tax2MinOrderTax { get; set; }
        public decimal Tax2MinOrderAmount { get; set; }
        public bool Tax2CompoundTax1 { get; set; }
        public bool Tax2CompoundTax3 { get; set; }
        public bool Tax2CompoundTax4 { get; set; }
        public bool Tax3MinOrderTax { get; set; }
        public decimal Tax3MinOrderAmount { get; set; }
        public bool Tax3CompoundTax1 { get; set; }
        public bool Tax3CompoundTax2 { get; set; }
        public bool Tax3CompoundTax4 { get; set; }
        public bool Tax4MinOrderTax { get; set; }
        public decimal Tax4MinOrderAmount { get; set; }
        public bool Tax4CompoundTax1 { get; set; }
        public bool Tax4CompoundTax2 { get; set; }
        public bool Tax4CompoundTax3 { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
