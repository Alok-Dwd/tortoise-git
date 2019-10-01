using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OrderLineUserDefinedTax
    {
        public string LocationCode { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }
        public short LineNumber { get; set; }
        public short Sequence { get; set; }
        public int TaxCategoryId { get; set; }
        public int TaxableByMargin { get; set; }
        public bool Tax1Discounted { get; set; }
        public float Tax1Rate { get; set; }
        public decimal Tax1ItemMinAmount { get; set; }
        public decimal Tax1TaxableAmount { get; set; }
        public bool Tax2Discounted { get; set; }
        public float Tax2Rate { get; set; }
        public decimal Tax2ItemMinAmount { get; set; }
        public decimal Tax2TaxableAmount { get; set; }
        public bool Tax3Discounted { get; set; }
        public float Tax3Rate { get; set; }
        public decimal Tax3ItemMinAmount { get; set; }
        public decimal Tax3TaxableAmount { get; set; }
        public bool Tax4Discounted { get; set; }
        public float Tax4Rate { get; set; }
        public decimal Tax4ItemMinAmount { get; set; }
        public decimal Tax4TaxableAmount { get; set; }
        public decimal OrderLineTaxableSale1 { get; set; }
        public decimal OrderLineTaxableSale2 { get; set; }
        public decimal OrderLineTaxableSale3 { get; set; }
        public decimal OrderLineTaxableSale4 { get; set; }
        public decimal OrderLineNonTaxableSale1 { get; set; }
        public decimal OrderLineNonTaxableSale2 { get; set; }
        public decimal OrderLineNonTaxableSale3 { get; set; }
        public decimal OrderLineNonTaxableSale4 { get; set; }
        public decimal OrderLineTax1 { get; set; }
        public decimal OrderLineTax2 { get; set; }
        public decimal OrderLineTax3 { get; set; }
        public decimal OrderLineTax4 { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
