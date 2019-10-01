using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ControlProperties
    {
        public string LocationCode { get; set; }
        public string Form { get; set; }
        public string Control { get; set; }
        public int XLeft { get; set; }
        public int YTop { get; set; }
        public byte? TabOrder { get; set; }
        public bool? Visibility { get; set; }
        public bool? Required { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public byte? MaxLength { get; set; }
        public byte? MaxLengthCap { get; set; }
        public byte? Lookup { get; set; }
        public string LabelName { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
