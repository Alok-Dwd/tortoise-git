using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class VsMetrixTemplate
    {
        public string LocationCode { get; set; }
        public string TemplateName { get; set; }
        public int Quadrant { get; set; }
        public int Page { get; set; }
        public string WindowName { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
    }
}
