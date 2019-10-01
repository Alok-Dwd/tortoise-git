using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MenuComboItems
    {
        public string LocationCode { get; set; }
        public string MenuCode { get; set; }
        public string SizeCode { get; set; }
        public string SubMenuCode { get; set; }
        public int ItemNumber { get; set; }
        public bool PromptForMenuItem { get; set; }
        public bool PromptForSizes { get; set; }
        public bool PromptForOptions { get; set; }
        public bool PromptForAttributes { get; set; }
        public bool? DefaultItem { get; set; }
        public int? Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal MinAmount { get; set; }
        public decimal MaxAmount { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
