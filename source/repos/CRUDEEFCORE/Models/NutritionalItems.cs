using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class NutritionalItems
    {
        public string LocationCode { get; set; }
        public string NutritionalItemCode { get; set; }
        public string NutritionalItemDescription { get; set; }
        public float RdaQuantity { get; set; }
        public string RdaUnit { get; set; }
        public bool ShowValueOnLabel { get; set; }
        public bool ShowPercentageOnLabel { get; set; }
        public int DisplayOrder { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
