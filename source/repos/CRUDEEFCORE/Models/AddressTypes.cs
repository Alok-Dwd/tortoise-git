using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class AddressTypes
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public string AddressType { get; set; }
        public string EnglishTextDescription { get; set; }
        public string Description { get; set; }
        public short? DisplayOrder { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
