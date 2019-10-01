using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class SaleReport
    {
        public DateTime? SaleDate { get; set; }
        public decimal? DailySummary { get; set; }
        public decimal? SaleTax { get; set; }
        public decimal? ComboSale { get; set; }
        public decimal? GoodSale { get; set; }
        public decimal? TotalsSales { get; set; }
        public decimal? SalesTax { get; set; }
        public decimal? TotalDiscounts { get; set; }
        public int? TotalOrders { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Tax { get; set; }
        public decimal? Discount { get; set; }
        public decimal? FinalTotal { get; set; }
        public decimal? NetSales { get; set; }
        public int? GoodOrders { get; set; }
        public decimal? SsubTotal { get; set; }
        public decimal? ServiceTax { get; set; }
        public decimal? Vat { get; set; }
        public decimal? TotalTax { get; set; }
        public decimal? TotalSales { get; set; }
        public decimal? DailySdiscount { get; set; }
    }
}
