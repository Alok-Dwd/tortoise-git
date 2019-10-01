using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ArAgingMethodTypes
    {
        public ArAgingMethodTypes()
        {
            ArAgingMethodTypesDescriptions = new HashSet<ArAgingMethodTypesDescriptions>();
        }

        public string LocationCode { get; set; }
        public int MethodTypeCode { get; set; }
        public string MethodDescription { get; set; }
        public string MethodValue { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual ICollection<ArAgingMethodTypesDescriptions> ArAgingMethodTypesDescriptions { get; set; }
    }
}
