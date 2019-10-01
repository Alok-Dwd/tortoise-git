using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MenuItemCategories
    {
        public string LocationCode { get; set; }
        public string MenuCode { get; set; }
        public string MenuCategoryCode { get; set; }
        public int? MenuCategoryDisplayOrder { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
