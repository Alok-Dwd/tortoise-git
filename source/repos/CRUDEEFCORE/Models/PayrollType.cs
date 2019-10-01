using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class PayrollType
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public byte PayrollTypeCode { get; set; }
        public string EnglishTextDescription { get; set; }
        public string Description { get; set; }
        public bool Monthly { get; set; }
        public byte? NumberOfDays { get; set; }
    }
}
