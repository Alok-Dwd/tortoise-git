using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OrderTypeCodes
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public string OrderTypeCode { get; set; }
        public string EnglishTextDescription { get; set; }
        public string Description { get; set; }
    }
}
