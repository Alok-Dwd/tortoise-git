using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MenuItemTypes
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public short MenuItemTypeCode { get; set; }
        public string EnglishTextDescription { get; set; }
        public string Description { get; set; }
    }
}
