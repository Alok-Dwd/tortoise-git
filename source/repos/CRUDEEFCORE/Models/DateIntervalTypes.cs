using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class DateIntervalTypes
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public string DateIntervalCode { get; set; }
        public float ApproximateDays { get; set; }
        public string EnglishTextDescription { get; set; }
        public string Description { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
