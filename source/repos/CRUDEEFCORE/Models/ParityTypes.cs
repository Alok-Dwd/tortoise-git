using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ParityTypes
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public byte ParityTypeCode { get; set; }
        public string EnglishTextDescription { get; set; }
        public string Description { get; set; }
    }
}
