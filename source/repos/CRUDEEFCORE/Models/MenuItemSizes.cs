using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MenuItemSizes
    {
        public string LocationCode { get; set; }
        public string MenuCode { get; set; }
        public string SizeCode { get; set; }
        public string Description { get; set; }
        public short DisplayOrder { get; set; }
        public short StatusCode { get; set; }
        public decimal BottleDeposit { get; set; }
        public decimal Price { get; set; }
        public decimal Price2 { get; set; }
        public string Barcode { get; set; }
        public bool DefaultSize { get; set; }
        public bool PriceByWeight { get; set; }
        public float TareWeight { get; set; }
        public bool OpenValueCard { get; set; }
        public decimal MinAmountOpenValueCard { get; set; }
        public decimal MaxAmountOpenValueCard { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }

        public virtual DeliveryFeeExemptedItem DeliveryFeeExemptedItem { get; set; }
    }
}
