using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MarketingOutputChoices
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public int KeyId { get; set; }
        public string SqlColName { get; set; }
        public string EnglishTextDescription { get; set; }
        public string Description { get; set; }
        public int TableCode { get; set; }
        public string Alias { get; set; }
        public bool Hidden { get; set; }
        public string TableName { get; set; }
        public bool? AggregateComboUsed { get; set; }
    }
}
