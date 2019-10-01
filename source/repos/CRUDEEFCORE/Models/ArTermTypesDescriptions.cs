using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ArTermTypesDescriptions
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public int TermTypeCode { get; set; }
        public string DefaultDescription { get; set; }
        public string ModifiedDescription { get; set; }

        public virtual ArTermTypes ArTermTypes { get; set; }
        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
