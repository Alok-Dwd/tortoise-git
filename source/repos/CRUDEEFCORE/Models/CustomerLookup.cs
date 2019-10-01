using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CustomerLookup
    {
        public string LocationCode { get; set; }
        public int CustomerCode { get; set; }
        public int CustomerLookupId { get; set; }
        public int CustomerLookupTypeCode { get; set; }
        public string CustomerLookupData { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
