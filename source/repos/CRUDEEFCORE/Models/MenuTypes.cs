using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MenuTypes
    {
        public string LocationCode { get; set; }
        public int MenuTypeId { get; set; }
        public string MenuTypeCode { get; set; }
        public string Description { get; set; }
        public string OrderDescription { get; set; }
        public int? DisplayOrder { get; set; }
        public bool? TextColor { get; set; }
        public byte[] MenuTypeImage { get; set; }
        public string DefaultMenuCategoryCode { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
