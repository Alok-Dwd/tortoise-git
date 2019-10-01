using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class IstStnDataHdr
    {
        public int StnId { get; set; }
        public string LocnCode { get; set; }
        public string InvNo { get; set; }
        public DateTime? InvDate { get; set; }
        public string VendCode { get; set; }
        public string XmlfileName { get; set; }
        public string StoreDlyId { get; set; }
        public DateTime? StoreDlyDate { get; set; }
        public string Status { get; set; }
    }
}
