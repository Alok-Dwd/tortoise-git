using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ToppingAmountCodes
    {
        public string LocationCode { get; set; }
        public string AmountCode { get; set; }
        public byte? SortOrder { get; set; }
        public short? NumberOfToppings { get; set; }
        public string Description { get; set; }
        public float? IfcToppingAmount { get; set; }
    }
}
