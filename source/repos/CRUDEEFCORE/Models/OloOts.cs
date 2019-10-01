using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OloOts
    {
        public string LocationCode { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }
        public string OtsNumber { get; set; }
        public DateTime Added { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual Orders Orders { get; set; }
    }
}
