using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CallerId
    {
        public string LocationCode { get; set; }
        public string Line { get; set; }
        public string CallDate { get; set; }
        public string CallTime { get; set; }
        public string PhoneNumber { get; set; }
        public string CustomerName { get; set; }
        public bool Answered { get; set; }
        public string PhoneSystemUniqueId { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
