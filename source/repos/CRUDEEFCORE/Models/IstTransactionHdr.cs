using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class IstTransactionHdr
    {
        public int TransactionId { get; set; }
        public string XmlfileName { get; set; }
        public string TransactionStatus { get; set; }
        public string LocationCode { get; set; }
        public string TransferLocationCode { get; set; }
        public int? DeliveryId { get; set; }
        public DateTime? TimeStamp { get; set; }
    }
}
