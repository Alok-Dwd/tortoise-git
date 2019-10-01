using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MenuComboItemSizes
    {
        public string LocationCode { get; set; }
        public string MenuCode { get; set; }
        public string SizeCode { get; set; }
        public string SubMenuCode { get; set; }
        public string SubSizeCode { get; set; }
        public int ItemNumber { get; set; }
        public bool? DefaultItem { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
