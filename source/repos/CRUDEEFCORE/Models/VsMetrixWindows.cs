using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class VsMetrixWindows
    {
        public string LocationCode { get; set; }
        public string WindowName { get; set; }
        public int Refresh { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
    }
}
