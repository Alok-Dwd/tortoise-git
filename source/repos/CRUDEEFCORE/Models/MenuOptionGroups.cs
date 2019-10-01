using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MenuOptionGroups
    {
        public string LocationCode { get; set; }
        public string MenuOptionGroupCode { get; set; }
        public string Description { get; set; }
        public string OrderDescription { get; set; }
        public short StatusCode { get; set; }
        public string MenuCategoryCode { get; set; }
        public int? DisplayOrder { get; set; }
        public int? MenuCategoryDisplayOrder { get; set; }
        public bool? ForSale { get; set; }
        public string ImageName { get; set; }
        public bool? TextColor { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
