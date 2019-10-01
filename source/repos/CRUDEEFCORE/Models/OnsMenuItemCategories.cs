using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OnsMenuItemCategories
    {
        public string LocationCode { get; set; }
        public string MenuCode { get; set; }
        public string MenuCategoryCode { get; set; }
        public int? MenuCategoryDisplayOrder { get; set; }
        public string AddedBy { get; set; }
        public string Added { get; set; }
    }
}
