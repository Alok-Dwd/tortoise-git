using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MenuOptionPriceDuplicateToppings
    {
        public string LocationCode { get; set; }
        public string MenuCode { get; set; }
        public string SizeCode { get; set; }
        public string MenuOptionGroupCode { get; set; }
        public string AmountCode { get; set; }
        public byte Cheese { get; set; }
        public decimal SinglePrice { get; set; }
        public decimal DoublePrice { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
