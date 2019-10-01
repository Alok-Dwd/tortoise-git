using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class PriorityCustomersNotification
    {
        public int Id { get; set; }
        public string LocationCode { get; set; }
        public string StoreName { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string OrderTypeCode { get; set; }
        public string ActionType { get; set; }
        public DateTime? OrderSaved { get; set; }
        public DateTime? AddedDate { get; set; }
        public bool? IsSync { get; set; }
        public int? RetryCount { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
