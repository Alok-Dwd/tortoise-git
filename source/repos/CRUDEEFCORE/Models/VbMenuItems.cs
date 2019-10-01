using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class VbMenuItems
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public int VbMenuItemId { get; set; }
        public string VbMenuItem { get; set; }
        public short? PositionInMenu { get; set; }
        public string VbEnglishDescription { get; set; }
        public string VbMenuItemDescription { get; set; }
        public int? VbMenuParent { get; set; }
        public short? MenuLevel { get; set; }
        public bool? Restrictable { get; set; }
        public bool? SpecialFunction { get; set; }
        public string Application { get; set; }
        public bool? AdminNotAllowed { get; set; }
    }
}
