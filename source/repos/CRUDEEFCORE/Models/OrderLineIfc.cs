using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OrderLineIfc
    {
        public string LocationCode { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public short LineNumber { get; set; }
        public short Sequence { get; set; }
        public string MenuCode { get; set; }
        public string SizeCode { get; set; }
        public string MenuOptionGroupCode { get; set; }
        public string InventoryCode { get; set; }
        public string PizzaPart { get; set; }
        public float PercentOfWhole { get; set; }
        public string AmountCode { get; set; }
        public float ToppingPercent { get; set; }
        public float MenuCodeQuantity { get; set; }
        public byte RecordType { get; set; }
        public string InvMenuCode { get; set; }
        public string InvSizeCode { get; set; }
        public bool DefaultValue { get; set; }
        public byte NumberOfToppings { get; set; }
        public float? IfcPortion { get; set; }
        public decimal? IfcAmount { get; set; }
    }
}
