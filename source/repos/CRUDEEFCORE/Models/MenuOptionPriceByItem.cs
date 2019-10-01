using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MenuOptionPriceByItem
    {
        public string LocationCode { get; set; }
        public string MenuCode { get; set; }
        public string SizeCode { get; set; }
        public string MenuOptionGroupCode { get; set; }
        public string SubMenuCode { get; set; }
        public string SubSizeCode { get; set; }
        public decimal Price { get; set; }
        public decimal Price2 { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
