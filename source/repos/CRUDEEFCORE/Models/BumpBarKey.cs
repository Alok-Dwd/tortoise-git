using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class BumpBarKey
    {
        public string LocationCode { get; set; }
        public int BumpBarKey1 { get; set; }
        public string BumpBarDesc { get; set; }
        public int AssignedKey { get; set; }
        public string AssignedKeyDesc { get; set; }
        public byte AssignedShift { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
