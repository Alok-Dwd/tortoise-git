using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ArTermTypes
    {
        public ArTermTypes()
        {
            ArTermTypesDescriptions = new HashSet<ArTermTypesDescriptions>();
        }

        public string LocationCode { get; set; }
        public int TermTypeCode { get; set; }
        public string TermDescription { get; set; }
        public int TermValue { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual ICollection<ArTermTypesDescriptions> ArTermTypesDescriptions { get; set; }
    }
}
