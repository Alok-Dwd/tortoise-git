using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class AuditTrail
    {
        public string LocationCode { get; set; }
        public int Id { get; set; }
        public int VbMenuItemId { get; set; }
        public bool AccessDenied { get; set; }
        public string OriginalValue { get; set; }
        public string NewValue { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public int? ActionId { get; set; }
        public string AddedPositionCode { get; set; }
    }
}
