using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OvenDescription
    {
        public string LocationCode { get; set; }
        public int Id { get; set; }
        public string OvenName { get; set; }
        public int BakeTime { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
