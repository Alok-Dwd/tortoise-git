using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class Months
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public int MonthValue { get; set; }
        public string DefaultText { get; set; }
        public string ModifiedText { get; set; }
    }
}
