using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OrderUserDefinedTax
    {
        public string LocationCode { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }
        public int CityCode { get; set; }
        public string PostalCode { get; set; }
        public bool CityBasedTax { get; set; }
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
        public int DeliveryFeeCategoryId { get; set; }
        public float DeliveryFeeRate1 { get; set; }
        public float DeliveryFeeRate2 { get; set; }
        public float DeliveryFeeRate3 { get; set; }
        public float DeliveryFeeRate4 { get; set; }
        public decimal SalesTax1 { get; set; }
        public decimal SalesTax2 { get; set; }
        public decimal SalesTax3 { get; set; }
        public decimal SalesTax4 { get; set; }
        public decimal TaxableSales1 { get; set; }
        public decimal TaxableSales2 { get; set; }
        public decimal TaxableSales3 { get; set; }
        public decimal TaxableSales4 { get; set; }
        public decimal NonTaxableSales1 { get; set; }
        public decimal NonTaxableSales2 { get; set; }
        public decimal NonTaxableSales3 { get; set; }
        public decimal NonTaxableSales4 { get; set; }
        public decimal DeliveryFeeTax1 { get; set; }
        public decimal DeliveryFeeTax2 { get; set; }
        public decimal DeliveryFeeTax3 { get; set; }
        public decimal DeliveryFeeTax4 { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
