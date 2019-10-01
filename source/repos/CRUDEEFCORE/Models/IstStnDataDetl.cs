using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class IstStnDataDetl
    {
        public int StnId { get; set; }
        public string LocnCode { get; set; }
        public int? RecNo { get; set; }
        public string ItemCode { get; set; }
        public string PosCode { get; set; }
        public decimal? ItemRate { get; set; }
        public decimal? OldRate { get; set; }
        public decimal? PosRate { get; set; }
        public decimal? ItemQty { get; set; }
        public decimal? PosQty { get; set; }
    }
}
