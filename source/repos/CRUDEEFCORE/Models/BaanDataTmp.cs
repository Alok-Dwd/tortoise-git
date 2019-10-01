using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class BaanDataTmp
    {
        public string LocnCode { get; set; }
        public int? RecNo { get; set; }
        public string InvNo { get; set; }
        public string DelyCode { get; set; }
        public string DelyType { get; set; }
        public DateTime? InvDate { get; set; }
        public string VendCode { get; set; }
        public string ItemCode { get; set; }
        public string PosCode { get; set; }
        public decimal? ItemRate { get; set; }
        public decimal? OldRate { get; set; }
        public decimal? PosRate { get; set; }
        public decimal? ItemQty { get; set; }
        public decimal? PosQty { get; set; }
        public DateTime? CurDate { get; set; }
        public string Status { get; set; }
    }
}
