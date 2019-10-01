using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MenuOptionPriceByNumber
    {
        public string LocationCode { get; set; }
        public string MenuCode { get; set; }
        public string SizeCode { get; set; }
        public string MenuOptionGroupCode { get; set; }
        public int OptionNumber { get; set; }
        public decimal Price { get; set; }
        public decimal Price2 { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
