using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MenuItemOptionGroups
    {
        public string LocationCode { get; set; }
        public string MenuCode { get; set; }
        public string MenuOptionGroupCode { get; set; }
        public bool? ItemSpecificPrice { get; set; }
        public short? MaxToChoose { get; set; }
        public short? MinToChoose { get; set; }
        public bool? ToppingGroup { get; set; }
        public int? DisplayOrder { get; set; }
        public bool RequireChoice { get; set; }
        public bool WeightOnKitchenDisplay { get; set; }
        public bool DisplayHalfButtons { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
