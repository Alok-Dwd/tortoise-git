using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OrderLineGiftCards
    {
        public string LocationCode { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public short LineNumber { get; set; }
        public short Sequence { get; set; }
        public byte GiftCardSequence { get; set; }
        public byte GiftCardTransactionType { get; set; }
        public byte[] GiftCardAccount { get; set; }
        public decimal GiftCardAmount { get; set; }
        public string GiftCardApproval { get; set; }
        public string TransactionNumber { get; set; }
        public byte EntryMethod { get; set; }
        public byte ActionCode { get; set; }
        public string ReturnCode { get; set; }
        public string ResponseCode { get; set; }
        public string ReferenceNumber { get; set; }
        public string BatchNumber { get; set; }
        public string RetrievalReferenceCode { get; set; }
        public string ResponseText { get; set; }
        public string Comment { get; set; }
        public string InternalSeqNumber { get; set; }
        public string ResultCode { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
