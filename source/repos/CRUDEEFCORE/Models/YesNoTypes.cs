using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class YesNoTypes
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public byte YesNoCode { get; set; }
        public string EnglishTextDescription { get; set; }
        public string Description { get; set; }
    }
}
