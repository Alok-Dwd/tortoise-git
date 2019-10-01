using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MenuItemOptionsDetails
    {
        public string LocationCode { get; set; }
        public string MenuCode { get; set; }
        public string MenuOptionGroupCode { get; set; }
        public string SubMenuCode { get; set; }
        public string SizeCode { get; set; }
        public bool? Cheese { get; set; }
        public bool? Sauce { get; set; }
        public string AmountCode { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
