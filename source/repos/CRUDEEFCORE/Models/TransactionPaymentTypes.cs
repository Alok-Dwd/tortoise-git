using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class TransactionPaymentTypes
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public byte TransactionPaymentType { get; set; }
        public string EnglishTextDescription { get; set; }
        public string Description { get; set; }
    }
}
