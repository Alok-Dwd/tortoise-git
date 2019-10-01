using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class AccountSubHead
    {
        public string LocationCode { get; set; }
        public int AccountId { get; set; }
        public string AccountCode { get; set; }
        public string SubAccountCode { get; set; }
        public string SubAccountCodeDescription { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
