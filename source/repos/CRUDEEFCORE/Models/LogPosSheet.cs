using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class LogPosSheet
    {
        public int? PosSheetNo { get; set; }
        public DateTime? ExportDate { get; set; }
        public string Message { get; set; }
        public string LocationCode { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
