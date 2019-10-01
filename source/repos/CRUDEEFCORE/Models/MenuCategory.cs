using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MenuCategory
    {
        public string LocationCode { get; set; }
        public string MenuCategoryCode { get; set; }
        public string Description { get; set; }
        public bool? Visible { get; set; }
        public string OrderDescription { get; set; }
        public int? DisplayOrder { get; set; }
        public bool? TextColor { get; set; }
        public short RemoteOrderAvailability { get; set; }
        public byte[] MenuCategoryImage { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
