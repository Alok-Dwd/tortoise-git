using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class DayOfWeekValues
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public short DayCode { get; set; }
        public string EnglishDescription { get; set; }
        public string ModifiedDescription { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
