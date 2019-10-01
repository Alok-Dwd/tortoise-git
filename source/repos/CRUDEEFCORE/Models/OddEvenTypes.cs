using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OddEvenTypes
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public short OddEven { get; set; }
        public string EnglishTextDescription { get; set; }
        public string Description { get; set; }
        public short DisplayOrder { get; set; }
    }
}
