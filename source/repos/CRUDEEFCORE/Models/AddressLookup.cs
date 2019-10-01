using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class AddressLookup
    {
        public string LocationCode { get; set; }
        public byte Type { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
