using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ArAgingMethodTypesDescriptions
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public int MethodTypeCode { get; set; }
        public string DefaultDescription { get; set; }
        public string ModifiedDescription { get; set; }

        public virtual ArAgingMethodTypes ArAgingMethodTypes { get; set; }
        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
