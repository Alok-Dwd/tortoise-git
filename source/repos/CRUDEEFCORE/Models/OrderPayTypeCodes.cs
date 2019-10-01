using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OrderPayTypeCodes
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public short OrderPayTypeCode { get; set; }
        public string EnglishTextDescription { get; set; }
        public string Description { get; set; }
        public int? CreditCardCode { get; set; }
        public bool? Active { get; set; }
        public int? SalesPayId { get; set; }
    }
}
