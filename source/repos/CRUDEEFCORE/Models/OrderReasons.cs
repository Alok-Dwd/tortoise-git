using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OrderReasons
    {
        public string LocationCode { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public int ReasonSequence { get; set; }
        public int ReasonGroupCode { get; set; }
        public int? ReasonId { get; set; }
        public string OtherInformation { get; set; }
        public bool Deleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
