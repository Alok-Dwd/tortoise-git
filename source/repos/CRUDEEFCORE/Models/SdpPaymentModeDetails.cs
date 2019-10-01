using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class SdpPaymentModeDetails
    {
        public int Sno { get; set; }
        public string DriverId { get; set; }
        public string LocationCode { get; set; }
        public decimal Amount { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string PaymentMode { get; set; }
        public int? PaymentLine { get; set; }
        public int? Sequence { get; set; }
        public int? PaymentStatus { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? CreateOn { get; set; }
        public string Reason { get; set; }
    }
}
