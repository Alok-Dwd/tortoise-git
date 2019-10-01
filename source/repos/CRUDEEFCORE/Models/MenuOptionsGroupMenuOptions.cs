using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MenuOptionsGroupMenuOptions
    {
        public string LocationCode { get; set; }
        public string MenuOptionGroupCode { get; set; }
        public string MenuCode { get; set; }
        public string SizeCode { get; set; }
        public decimal Price { get; set; }
        public int? DisplayOrder { get; set; }
        public int? KitchenDisplayOrder { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
