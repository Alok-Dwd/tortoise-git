using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OrderWallet
    {
        public string LocationCode { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }
        public string TentNumber { get; set; }
        public decimal AodAmount { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public bool OloSyncStatus { get; set; }
        public DateTime? OloSyncDate { get; set; }
        public int Sequence { get; set; }
        public string ApiRequest { get; set; }
        public string ApiResponse { get; set; }
        public int ApiAttempt { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual Orders Orders { get; set; }
    }
}
