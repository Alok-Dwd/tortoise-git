using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MarketingOperators
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public int OperatorCode { get; set; }
        public string EnglishTextDescription { get; set; }
        public string Description { get; set; }
        public string SqlCode { get; set; }
        public decimal Modifier { get; set; }
        public bool Range { get; set; }
    }
}
