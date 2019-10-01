using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class LabelConfig
    {
        public int? ScreenNumber { get; set; }
        public int? DisplaySequenceNumber { get; set; }
        public string Labeltext { get; set; }
        public string LabelPropertyName { get; set; }
        public bool? IsOneColumnDisplay { get; set; }
        public bool? IsActive { get; set; }
        public string BackColor { get; set; }
        public string ForeColor { get; set; }
        public int? FontSize { get; set; }
    }
}
