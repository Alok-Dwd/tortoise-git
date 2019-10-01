using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ProcessorTrackingLog
    {
        public string LocationCode { get; set; }
        public int LogId { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }
        public decimal TransactionAmount { get; set; }
        public byte CardTypeId { get; set; }
        public byte TransactionType { get; set; }
        public byte EntryMethod { get; set; }
        public string CustomerName { get; set; }
        public string RetrievalReferenceCode { get; set; }
        public string ProcessorResponse { get; set; }
        public int WorkstationId { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
