using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MenuItemTypes1
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public bool MenuItemType { get; set; }
        public string EnglishTextDescription { get; set; }
        public string Description { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
