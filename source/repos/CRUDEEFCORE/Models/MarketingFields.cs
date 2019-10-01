using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MarketingFields
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public int CriteriaKey { get; set; }
        public string EnglishTextDescription { get; set; }
        public string Description { get; set; }
        public int VariableType { get; set; }
        public string SqlTag { get; set; }
        public int DisplayOrder { get; set; }
        public decimal Modifier { get; set; }
        public bool Range { get; set; }
        public bool SpFlag { get; set; }
        public string StoredProcedure { get; set; }
        public bool NeedLocation { get; set; }
        public bool NeedParen { get; set; }
        public int SpecialCode { get; set; }
        public int TableCode { get; set; }
        public bool NeedLanguage { get; set; }
    }
}
