using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class EodDataSyncLog
    {
        public string LocationCode { get; set; }
        public DateTime SystemDate { get; set; }
        public string ProcessName { get; set; }
        public decimal? ProcessFlag { get; set; }
        public string ProcessError { get; set; }
        public DateTime? Added { get; set; }
    }
}
