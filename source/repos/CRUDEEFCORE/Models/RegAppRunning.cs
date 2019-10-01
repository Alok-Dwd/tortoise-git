using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class RegAppRunning
    {
        public string LocationCode { get; set; }
        public string ExeName { get; set; }
        public string ComputerName { get; set; }
        public DateTime LastUpdatedTime { get; set; }
    }
}
