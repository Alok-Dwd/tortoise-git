using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CouponTypes
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public short CouponTypeCode { get; set; }
        public string EnglishTextDescription { get; set; }
        public string Description { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
